namespace OOP2Projekt
{
    partial class LoginForm
    {

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            labelDobrodosli = new System.Windows.Forms.Label();
            labelKorisnickoIme = new System.Windows.Forms.Label();
            textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            labelLozinka = new System.Windows.Forms.Label();
            textBoxLozinka = new System.Windows.Forms.TextBox();
            buttonRegistracija = new System.Windows.Forms.Button();
            buttonPrijava = new System.Windows.Forms.Button();
            linkLabelLozinka = new System.Windows.Forms.LinkLabel();
            comboBoxLanguage = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // labelDobrodosli
            // 
            labelDobrodosli.AutoSize = true;
            labelDobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelDobrodosli.Location = new System.Drawing.Point(400, 70);
            labelDobrodosli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelDobrodosli.Name = "labelDobrodosli";
            labelDobrodosli.Size = new System.Drawing.Size(134, 31);
            labelDobrodosli.TabIndex = 7;
            labelDobrodosli.Text = "Welcome!";
            // 
            // labelKorisnickoIme
            // 
            labelKorisnickoIme.AutoSize = true;
            labelKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelKorisnickoIme.Location = new System.Drawing.Point(373, 172);
            labelKorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelKorisnickoIme.Name = "labelKorisnickoIme";
            labelKorisnickoIme.Size = new System.Drawing.Size(70, 16);
            labelKorisnickoIme.TabIndex = 8;
            labelKorisnickoIme.Text = "Username";
            // 
            // textBoxKorisnickoIme
            // 
            textBoxKorisnickoIme.ForeColor = System.Drawing.SystemColors.GrayText;
            textBoxKorisnickoIme.Location = new System.Drawing.Point(377, 208);
            textBoxKorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            textBoxKorisnickoIme.Size = new System.Drawing.Size(219, 23);
            textBoxKorisnickoIme.TabIndex = 9;
            // 
            // labelLozinka
            // 
            labelLozinka.AutoSize = true;
            labelLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelLozinka.Location = new System.Drawing.Point(373, 254);
            labelLozinka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLozinka.Name = "labelLozinka";
            labelLozinka.Size = new System.Drawing.Size(67, 16);
            labelLozinka.TabIndex = 10;
            labelLozinka.Text = "Password";
            // 
            // textBoxLozinka
            // 
            textBoxLozinka.ForeColor = System.Drawing.SystemColors.GrayText;
            textBoxLozinka.Location = new System.Drawing.Point(377, 288);
            textBoxLozinka.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxLozinka.Name = "textBoxLozinka";
            textBoxLozinka.Size = new System.Drawing.Size(219, 23);
            textBoxLozinka.TabIndex = 11;
            // 
            // buttonRegistracija
            // 
            buttonRegistracija.Location = new System.Drawing.Point(377, 415);
            buttonRegistracija.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonRegistracija.Name = "buttonRegistracija";
            buttonRegistracija.Size = new System.Drawing.Size(219, 27);
            buttonRegistracija.TabIndex = 14;
            buttonRegistracija.Text = "Register";
            buttonRegistracija.UseVisualStyleBackColor = true;
            buttonRegistracija.Click += buttonRegistracija_Click;
            // 
            // buttonPrijava
            // 
            buttonPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonPrijava.Location = new System.Drawing.Point(377, 366);
            buttonPrijava.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonPrijava.Name = "buttonPrijava";
            buttonPrijava.Size = new System.Drawing.Size(219, 27);
            buttonPrijava.TabIndex = 12;
            buttonPrijava.Text = "Log in";
            buttonPrijava.UseVisualStyleBackColor = true;
            buttonPrijava.Click += buttonPrijava_Click;
            // 
            // linkLabelLozinka
            // 
            linkLabelLozinka.AutoSize = true;
            linkLabelLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            linkLabelLozinka.Location = new System.Drawing.Point(490, 325);
            linkLabelLozinka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabelLozinka.Name = "linkLabelLozinka";
            linkLabelLozinka.Size = new System.Drawing.Size(91, 13);
            linkLabelLozinka.TabIndex = 13;
            linkLabelLozinka.TabStop = true;
            linkLabelLozinka.Text = "Forgot password?";
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Items.AddRange(new object[] { "Hrvatski", "English" });
            comboBoxLanguage.Location = new System.Drawing.Point(780, 91);
            comboBoxLanguage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new System.Drawing.Size(140, 23);
            comboBoxLanguage.TabIndex = 30;
            comboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(comboBoxLanguage);
            Controls.Add(buttonRegistracija);
            Controls.Add(linkLabelLozinka);
            Controls.Add(buttonPrijava);
            Controls.Add(textBoxLozinka);
            Controls.Add(labelLozinka);
            Controls.Add(textBoxKorisnickoIme);
            Controls.Add(labelKorisnickoIme);
            Controls.Add(labelDobrodosli);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "LoginForm";
            Text = "Prijava";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelDobrodosli;
        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.TextBox textBoxKorisnickoIme;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Button buttonRegistracija;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.LinkLabel linkLabelLozinka;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
    }
}

