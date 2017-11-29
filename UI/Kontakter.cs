using AdressbokV2.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace AdressbokV2
{
    public partial class Kontakter : Form
    {
        public Kontakter()
        {
            InitializeComponent();
        }

        //Lägg till Kontakt
        private void AddButton_Click(object sender, EventArgs e)
        {
            if(ContactTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Ange kontakttyp!", "Error!");
                return;
            }

            using (AdressBokContext context = new AdressBokContext())
            {
                var newAdress = new Adress();
                newAdress.StreetName = StreetTextBox.Text;
                newAdress.PostCode = PostnummerTextBox.Text;
                newAdress.City = CityTextBox.Text;

                var cType = context.ContactTypes.SingleOrDefault(c => c.Name == ContactTypeComboBox.Text);

                var newContact = new Contact
                {
                    Name = NameTextBox.Text,
                    Email = EmailTextBox.Text,
                    Phone = PhoneTextBox.Text,
                    Adresses = new List<Adress> { newAdress },
                    ContactTypes = new List<ContactType> { cType }
                };

                context.Contacts.Add(newContact);
                context.SaveChanges();

                LaddaKontakter();
            }

            MessageBox.Show("Kontakt skapad!", "Success!");
        }
        //UPPDATERA ENBART ADRESS
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (AdressBokContext context = new AdressBokContext())
            {
                //Hämta adressIdet
                var adress = context.Adresses.Find(gvShowAdresses.SelectedRows[0].Cells["Id"].Value);

                //Lägg till dom upppdaterade värdena
                adress.City = CityTextBox.Text;
                adress.PostCode = PostnummerTextBox.Text;
                adress.StreetName = StreetTextBox.Text;

                context.SaveChanges();

                MessageBox.Show("Uppdaterat adress!");

                ShowContactAdresses(int.Parse(gvShowContacts.SelectedRows[0].Cells["Id"].Value.ToString()));
            }

        }
        //ta bort ennbart ADRESS
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            using (AdressBokContext context = new AdressBokContext())
            {
                var removeAddress = this.gvShowAdresses.SelectedRows[0].Cells[0].FormattedValue.ToString();
                int remov = int.Parse(removeAddress);
                var removeThis = context.Adresses.First(x => x.Id == remov);

                var removeCont = int.Parse(gvShowContacts.SelectedRows[0].Cells[0].Value.ToString());

                var contact = context.Contacts.Find(removeCont);

                contact.Adresses.RemoveAll(a => a.Id == remov);




                //context.Adresses.Remove(removeThis);
                context.SaveChanges();
                ShowContactAdresses(removeCont);
            }
        }
        //Sök funktionen
        private void SearchButton_Click(object sender, EventArgs e)
        {
            var kTyp = cbSökKontaktTyp.Text;
            var xxkTyp = cbSökKontaktTyp.SelectedItem as ContactType;
            var nSök = txtSökNamn.Text;
            var aSök = txtSökStad.Text;

            using (AdressBokContext context = new AdressBokContext())
            {
                var contacts = context.Contacts.Where(c => c.Name.Contains(nSök));

                if (!string.IsNullOrWhiteSpace(aSök))
                {
                    contacts = context.Contacts.Where(c => c.Adresses.Any(a => a.City.Contains(aSök)));
                }

                if (xxkTyp != null && xxkTyp.Id != 0)
                {
                    contacts = contacts.Where(c => c.ContactTypes.Any(ct => ct.Id == xxkTyp.Id));
                }

                var result = contacts.ToList();


                gvShowContacts.DataSource = result.Select(c => new Models.GridViewCustomer
                {
                    Id = c.Id,
                    Email = c.Email,
                    Namn = c.Name,
                    Telefon = c.Phone,
                    KontaktTyp = c.ContactTypes.FirstOrDefault()?.Name
                }).ToList();


                return;






                //var allaadresser = context.Adresses.ToList();
                var matchandekontakter = context.Contacts.Where(a => a.Name.Contains(nSök)).ToList();
                //var mygel = context.ContactTypes.Where(c => c.Name == kTyp).FirstOrDefault();
                var matchandeadresser = context.Adresses.Where(a => a.City.Contains(aSök)).ToList();

                var matchkontaktktyp = matchandekontakter.Where(a => a.ContactTypes.Select(c => c.Name == kTyp).First()).ToList();

                var matchadresscontact = matchandeadresser.Where(a => a.Contacts.Select(c => c.Name.Contains(nSök)).First()).ToList();
                var matchandekontakttypadress = matchkontaktktyp.SelectMany(c => c.Adresses).ToList();
                // var selectkorv = context.Adresses.Where(x=>x.)


                if (!string.IsNullOrWhiteSpace(kTyp))
                {
                    var query2 = from a in matchkontaktktyp
                                 select new Models.GridViewCustomer
                                 {
                                     Id = a.Id,
                                     Email = a.Email,
                                     KontaktTyp = a.ContactTypes.FirstOrDefault().Name,
                                     Namn = a.Name,
                                     Telefon = a.Phone

                                 };
                    gvShowContacts.DataSource = query2.ToList();

                    var query4 = from b in matchandekontakttypadress
                                 select new Models.GridViewAdresses
                                 {
                                     Adress = b.StreetName,
                                     Id = b.Id,
                                     Postnummer = b.PostCode,
                                     Postort = b.City
                                 };
                    cbSökKontaktTyp.SelectedIndex = -1;
                }

                else
                {
                    var query = from a in matchandekontakter
                                select new Models.GridViewCustomer
                                {
                                    Id = a.Id,
                                    Email = a.Email,
                                    KontaktTyp = a.ContactTypes.FirstOrDefault().Name,
                                    Namn = a.Name,
                                    Telefon = a.Phone
                                };

                    var query3 = from b in matchadresscontact
                                 select new Models.GridViewAdresses
                                 {
                                     Adress = b.StreetName,
                                     Id = b.Id,
                                     Postort = b.City,
                                     Postnummer = b.PostCode
                                 };
                    gvShowAdresses.DataSource = query3.ToList();
                    //gvShowAdresses.DataSource = matchandeadresser.Select(a => a.Contacts.Where(c => c.Name.Contains(nSök)));
                    gvShowContacts.DataSource = query.ToList();
                }
            }
        }

        private void Kontakter_Load(object sender, EventArgs e)
        {

            LaddaKontakter();
            LaddaKontaktTyper();

        }
        //Ladda in alla kontakt typer
        private void LaddaKontaktTyper()
        {
            ContactTypeComboBox.Items.AddRange(GetAllContactTypes().ToArray());
            ContactTypeComboBox.DisplayMember = "Name";
            ContactTypeComboBox.ValueMember = "Id";

            cbSökKontaktTyp.Items.AddRange(GetAllContactTypes().ToArray());
            cbSökKontaktTyp.DisplayMember = "Name";
            cbSökKontaktTyp.ValueMember = "Id";
            cbSökKontaktTyp.Items.Insert(0, new ContactType { Id = 0, Name = "Välj kontakttyp" });
            cbSökKontaktTyp.SelectedIndex = 0;
        }
        //Ladda alla existerande kontakter till gridviewn
        private void LaddaKontakter()
        {
            using (AdressBokContext context = new AdressBokContext())
            {
                var query = from c in context.Contacts
                            select new Models.GridViewCustomer
                            {
                                Id = c.Id,
                                Namn = c.Name,
                                Telefon = c.Phone,
                                KontaktTyp = c.ContactTypes.FirstOrDefault().Name,
                                Email = c.Email

                            };
                              

                gvShowContacts.DataSource = query.ToList();
                this.gvShowContacts.Columns["Id"].Visible = false;
            }
        }
        //Visa alla adresser som är kopplade till kontakten
        private void ShowContactAdresses(int contactId)
        {
            using (AdressBokContext context = new AdressBokContext())
            {
                //Välj ut kontakten med kontaktId
                var chosenContact = context.Contacts.FirstOrDefault(x => x.Id == contactId);

                //Lista utav denna kontakts adresser
                var contactAdresses = chosenContact.Adresses;


                var query = from a in contactAdresses

                            select new Models.GridViewAdresses
                            {
                                Id = a.Id,
                                Adress = a.StreetName,
                                Postort = a.City,
                                Postnummer = a.PostCode
                            };

                gvShowAdresses.DataSource = query.ToList();
                this.gvShowAdresses.Columns["Id"].Visible = false;
            }

        }
        //Editera-funktionen
        private void cbEditera_CheckedChanged(object sender, EventArgs e)
        {
            {
                EmailTextBox.Enabled = cbEditera.Checked;
                StreetTextBox.Enabled = cbEditera.Checked;
                NameTextBox.Enabled = cbEditera.Checked;
                PostnummerTextBox.Enabled = cbEditera.Checked;
                CityTextBox.Enabled = cbEditera.Checked;
                PhoneTextBox.Enabled = cbEditera.Checked;
                ContactTypeComboBox.Enabled = cbEditera.Checked;
                UpdateButton.Enabled = cbEditera.Checked;

            }
        }
        //Lägg till adresser för update-funktionen
        private void gvShowAdresses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gvShowAdresses.Rows[e.RowIndex];

                StreetTextBox.Text = row.Cells["Adress"].Value.ToString();
                PostnummerTextBox.Text = row.Cells["Postnummer"].Value.ToString();
                CityTextBox.Text = row.Cells["Postort"].Value.ToString();
            }

        }
        //Lägg till kontaktuppgifter i informationsfältet
        private void gvShowContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gvShowContacts.Rows[e.RowIndex];

                NameTextBox.Text = row.Cells["Namn"].Value.ToString();
                //StreetTextBox.Text = row.Cells["Adress"].Value.ToString();
                //PostnummerTextBox.Text = row.Cells["Postnummer"].Value.ToString();
                //CityTextBox.Text = row.Cells["Stad"].Value.ToString();
                PhoneTextBox.Text = row.Cells["Telefon"].Value.ToString();
                EmailTextBox.Text = row.Cells["Email"].Value.ToString();

                foreach (ContactType item in ContactTypeComboBox.Items)
                {
                    if (item.Name == row.Cells[columnName: "KontaktTyp"].Value.ToString())
                    {
                        ContactTypeComboBox.SelectedItem = item;
                        break;
                    }
                }

            }

            var Id = gvShowContacts.CurrentRow.Cells[0].FormattedValue.ToString();

            var newId = int.Parse(Id);
            ShowContactAdresses(newId);
        }
        //Alla kontakttyper som finns i databasen
        public BindingList<ContactType> GetAllContactTypes()
        {
            BindingList<ContactType> ContactTypes;

            using (var db = new AdressBokContext())
            {
                var query = db.ContactTypes.ToList();


                ContactTypes = new BindingList<ContactType>(query.ToList());
            }
            return ContactTypes;

        }
        //Lägg till adress till den specifika kontakten
        private void btnLäggTillAdress_Click(object sender, EventArgs e)
        {
            //Lägg till en adress till den valda kontakten
            Contact contact;
            using (AdressBokContext context = new AdressBokContext())
            {
                contact = context.Contacts.Find(gvShowContacts.SelectedRows[0].Cells["Id"].Value);

                Adress nyadress = new Adress();
                nyadress.PostCode = PostnummerTextBox.Text;
                nyadress.StreetName = StreetTextBox.Text;
                nyadress.City = CityTextBox.Text;

                contact.Adresses.Add(nyadress);


                context.SaveChanges();

                MessageBox.Show("Lagt till ny adress!");

                ShowContactAdresses(contact.Id);

            }
        }
    }
}
