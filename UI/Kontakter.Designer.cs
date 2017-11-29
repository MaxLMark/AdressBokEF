namespace AdressbokV2
{
    partial class Kontakter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.PostnummerTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ContactTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.NameLable = new System.Windows.Forms.Label();
            this.StreetLable = new System.Windows.Forms.Label();
            this.PostnummerLable = new System.Windows.Forms.Label();
            this.CityLable = new System.Windows.Forms.Label();
            this.EmailLable = new System.Windows.Forms.Label();
            this.PhoneLable = new System.Windows.Forms.Label();
            this.KontaktTypLabel = new System.Windows.Forms.Label();
            this.SearchLable = new System.Windows.Forms.Label();
            this.gvShowContacts = new System.Windows.Forms.DataGridView();
            this.cbEditera = new System.Windows.Forms.CheckBox();
            this.gvShowAdresses = new System.Windows.Forms.DataGridView();
            this.btnLäggTillAdress = new System.Windows.Forms.Button();
            this.lblSökNamn = new System.Windows.Forms.Label();
            this.lblSökStad = new System.Windows.Forms.Label();
            this.txtSökNamn = new System.Windows.Forms.TextBox();
            this.txtSökStad = new System.Windows.Forms.TextBox();
            this.cbSökKontaktTyp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowAdresses)).BeginInit();
            this.SuspendLayout();
            // 
            // CityTextBox
            // 
            this.CityTextBox.Enabled = false;
            this.CityTextBox.Location = new System.Drawing.Point(461, 307);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 22);
            this.CityTextBox.TabIndex = 1;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Enabled = false;
            this.EmailTextBox.Location = new System.Drawing.Point(462, 363);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(100, 22);
            this.EmailTextBox.TabIndex = 2;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Enabled = false;
            this.PhoneTextBox.Location = new System.Drawing.Point(461, 420);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(110, 22);
            this.PhoneTextBox.TabIndex = 3;
            // 
            // PostnummerTextBox
            // 
            this.PostnummerTextBox.Enabled = false;
            this.PostnummerTextBox.Location = new System.Drawing.Point(461, 249);
            this.PostnummerTextBox.Name = "PostnummerTextBox";
            this.PostnummerTextBox.Size = new System.Drawing.Size(100, 22);
            this.PostnummerTextBox.TabIndex = 4;
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Enabled = false;
            this.StreetTextBox.Location = new System.Drawing.Point(461, 189);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(100, 22);
            this.StreetTextBox.TabIndex = 5;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Location = new System.Drawing.Point(461, 134);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(187, 22);
            this.NameTextBox.TabIndex = 6;
            // 
            // ContactTypeComboBox
            // 
            this.ContactTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContactTypeComboBox.Enabled = false;
            this.ContactTypeComboBox.FormattingEnabled = true;
            this.ContactTypeComboBox.Location = new System.Drawing.Point(689, 95);
            this.ContactTypeComboBox.Name = "ContactTypeComboBox";
            this.ContactTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.ContactTypeComboBox.TabIndex = 7;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(375, 88);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 43);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Sök";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(1164, 249);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(135, 32);
            this.RemoveButton.TabIndex = 9;
            this.RemoveButton.Text = "Ta bort address";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(640, 331);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(135, 35);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Lägg till kontakt";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(640, 372);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(135, 35);
            this.UpdateButton.TabIndex = 11;
            this.UpdateButton.Text = "Updatera adress";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Location = new System.Drawing.Point(462, 114);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(45, 17);
            this.NameLable.TabIndex = 13;
            this.NameLable.Text = "Namn";
            // 
            // StreetLable
            // 
            this.StreetLable.AutoSize = true;
            this.StreetLable.Location = new System.Drawing.Point(462, 169);
            this.StreetLable.Name = "StreetLable";
            this.StreetLable.Size = new System.Drawing.Size(39, 17);
            this.StreetLable.TabIndex = 14;
            this.StreetLable.Text = "Gata";
            // 
            // PostnummerLable
            // 
            this.PostnummerLable.AutoSize = true;
            this.PostnummerLable.Location = new System.Drawing.Point(461, 230);
            this.PostnummerLable.Name = "PostnummerLable";
            this.PostnummerLable.Size = new System.Drawing.Size(87, 17);
            this.PostnummerLable.TabIndex = 15;
            this.PostnummerLable.Text = "Postnummer";
            // 
            // CityLable
            // 
            this.CityLable.AutoSize = true;
            this.CityLable.Location = new System.Drawing.Point(461, 287);
            this.CityLable.Name = "CityLable";
            this.CityLable.Size = new System.Drawing.Size(53, 17);
            this.CityLable.TabIndex = 16;
            this.CityLable.Text = "Postort";
            // 
            // EmailLable
            // 
            this.EmailLable.AutoSize = true;
            this.EmailLable.Location = new System.Drawing.Point(459, 343);
            this.EmailLable.Name = "EmailLable";
            this.EmailLable.Size = new System.Drawing.Size(42, 17);
            this.EmailLable.TabIndex = 17;
            this.EmailLable.Text = "Email";
            // 
            // PhoneLable
            // 
            this.PhoneLable.AutoSize = true;
            this.PhoneLable.Location = new System.Drawing.Point(462, 400);
            this.PhoneLable.Name = "PhoneLable";
            this.PhoneLable.Size = new System.Drawing.Size(56, 17);
            this.PhoneLable.TabIndex = 18;
            this.PhoneLable.Text = "Telefon";
            // 
            // KontaktTypLabel
            // 
            this.KontaktTypLabel.AutoSize = true;
            this.KontaktTypLabel.Location = new System.Drawing.Point(686, 75);
            this.KontaktTypLabel.Name = "KontaktTypLabel";
            this.KontaktTypLabel.Size = new System.Drawing.Size(84, 17);
            this.KontaktTypLabel.TabIndex = 19;
            this.KontaktTypLabel.Text = "Kontakt Typ";
            // 
            // SearchLable
            // 
            this.SearchLable.AutoSize = true;
            this.SearchLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLable.Location = new System.Drawing.Point(167, 9);
            this.SearchLable.Name = "SearchLable";
            this.SearchLable.Size = new System.Drawing.Size(67, 32);
            this.SearchLable.TabIndex = 20;
            this.SearchLable.Text = "Sök";
            // 
            // gvShowContacts
            // 
            this.gvShowContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShowContacts.Location = new System.Drawing.Point(12, 144);
            this.gvShowContacts.MultiSelect = false;
            this.gvShowContacts.Name = "gvShowContacts";
            this.gvShowContacts.ReadOnly = true;
            this.gvShowContacts.RowTemplate.Height = 24;
            this.gvShowContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvShowContacts.Size = new System.Drawing.Size(438, 407);
            this.gvShowContacts.TabIndex = 21;
            this.gvShowContacts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvShowContacts_CellClick);
            // 
            // cbEditera
            // 
            this.cbEditera.AutoSize = true;
            this.cbEditera.Location = new System.Drawing.Point(640, 226);
            this.cbEditera.Name = "cbEditera";
            this.cbEditera.Size = new System.Drawing.Size(75, 21);
            this.cbEditera.TabIndex = 22;
            this.cbEditera.Text = "Editera";
            this.cbEditera.UseVisualStyleBackColor = true;
            this.cbEditera.CheckedChanged += new System.EventHandler(this.cbEditera_CheckedChanged);
            // 
            // gvShowAdresses
            // 
            this.gvShowAdresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShowAdresses.Location = new System.Drawing.Point(867, 75);
            this.gvShowAdresses.MultiSelect = false;
            this.gvShowAdresses.Name = "gvShowAdresses";
            this.gvShowAdresses.ReadOnly = true;
            this.gvShowAdresses.RowTemplate.Height = 24;
            this.gvShowAdresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvShowAdresses.Size = new System.Drawing.Size(432, 150);
            this.gvShowAdresses.TabIndex = 23;
            this.gvShowAdresses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvShowAdresses_CellClick);
            // 
            // btnLäggTillAdress
            // 
            this.btnLäggTillAdress.Location = new System.Drawing.Point(1024, 249);
            this.btnLäggTillAdress.Name = "btnLäggTillAdress";
            this.btnLäggTillAdress.Size = new System.Drawing.Size(116, 32);
            this.btnLäggTillAdress.TabIndex = 24;
            this.btnLäggTillAdress.Text = "Lägg till adress";
            this.btnLäggTillAdress.UseVisualStyleBackColor = true;
            this.btnLäggTillAdress.Click += new System.EventHandler(this.btnLäggTillAdress_Click);
            // 
            // lblSökNamn
            // 
            this.lblSökNamn.AutoSize = true;
            this.lblSökNamn.Location = new System.Drawing.Point(25, 55);
            this.lblSökNamn.Name = "lblSökNamn";
            this.lblSökNamn.Size = new System.Drawing.Size(49, 17);
            this.lblSökNamn.TabIndex = 25;
            this.lblSökNamn.Text = "Namn:";
            // 
            // lblSökStad
            // 
            this.lblSökStad.AutoSize = true;
            this.lblSökStad.Location = new System.Drawing.Point(25, 95);
            this.lblSökStad.Name = "lblSökStad";
            this.lblSökStad.Size = new System.Drawing.Size(41, 17);
            this.lblSökStad.TabIndex = 26;
            this.lblSökStad.Text = "Stad:";
            // 
            // txtSökNamn
            // 
            this.txtSökNamn.Location = new System.Drawing.Point(81, 55);
            this.txtSökNamn.Name = "txtSökNamn";
            this.txtSökNamn.Size = new System.Drawing.Size(100, 22);
            this.txtSökNamn.TabIndex = 27;
            // 
            // txtSökStad
            // 
            this.txtSökStad.Location = new System.Drawing.Point(81, 95);
            this.txtSökStad.Name = "txtSökStad";
            this.txtSökStad.Size = new System.Drawing.Size(100, 22);
            this.txtSökStad.TabIndex = 28;
            // 
            // cbSökKontaktTyp
            // 
            this.cbSökKontaktTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSökKontaktTyp.FormattingEnabled = true;
            this.cbSökKontaktTyp.Location = new System.Drawing.Point(207, 68);
            this.cbSökKontaktTyp.Name = "cbSökKontaktTyp";
            this.cbSökKontaktTyp.Size = new System.Drawing.Size(140, 24);
            this.cbSökKontaktTyp.TabIndex = 29;
            // 
            // Kontakter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 601);
            this.Controls.Add(this.cbSökKontaktTyp);
            this.Controls.Add(this.txtSökStad);
            this.Controls.Add(this.txtSökNamn);
            this.Controls.Add(this.lblSökStad);
            this.Controls.Add(this.lblSökNamn);
            this.Controls.Add(this.btnLäggTillAdress);
            this.Controls.Add(this.gvShowAdresses);
            this.Controls.Add(this.cbEditera);
            this.Controls.Add(this.gvShowContacts);
            this.Controls.Add(this.SearchLable);
            this.Controls.Add(this.KontaktTypLabel);
            this.Controls.Add(this.PhoneLable);
            this.Controls.Add(this.EmailLable);
            this.Controls.Add(this.CityLable);
            this.Controls.Add(this.PostnummerLable);
            this.Controls.Add(this.StreetLable);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ContactTypeComboBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.PostnummerTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Name = "Kontakter";
            this.Text = "Kontakter";
            this.Load += new System.EventHandler(this.Kontakter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvShowContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowAdresses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox PostnummerTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox ContactTypeComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.Label StreetLable;
        private System.Windows.Forms.Label PostnummerLable;
        private System.Windows.Forms.Label CityLable;
        private System.Windows.Forms.Label EmailLable;
        private System.Windows.Forms.Label PhoneLable;
        private System.Windows.Forms.Label KontaktTypLabel;
        private System.Windows.Forms.Label SearchLable;
        private System.Windows.Forms.DataGridView gvShowContacts;
        private System.Windows.Forms.CheckBox cbEditera;
        private System.Windows.Forms.DataGridView gvShowAdresses;
        private System.Windows.Forms.Button btnLäggTillAdress;
        private System.Windows.Forms.Label lblSökNamn;
        private System.Windows.Forms.Label lblSökStad;
        private System.Windows.Forms.TextBox txtSökNamn;
        private System.Windows.Forms.TextBox txtSökStad;
        private System.Windows.Forms.ComboBox cbSökKontaktTyp;
    }
}

