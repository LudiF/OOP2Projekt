namespace OOP2Projekt
{
    partial class LoginForm
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
            this.labelDobrodosli = new System.Windows.Forms.Label();
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.buttonRegistracija = new System.Windows.Forms.Button();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.linkLabelLozinka = new System.Windows.Forms.LinkLabel();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelDobrodosli
            // 
            this.labelDobrodosli.AutoSize = true;
            this.labelDobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDobrodosli.Location = new System.Drawing.Point(343, 61);
            this.labelDobrodosli.Name = "labelDobrodosli";
            this.labelDobrodosli.Size = new System.Drawing.Size(134, 31);
            this.labelDobrodosli.TabIndex = 7;
            this.labelDobrodosli.Text = "Welcome!";
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorisnickoIme.Location = new System.Drawing.Point(320, 149);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(70, 16);
            this.labelKorisnickoIme.TabIndex = 8;
            this.labelKorisnickoIme.Text = "Username";
            // 
            // textBoxKorisnickoIme
            // 
            this.textBoxKorisnickoIme.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxKorisnickoIme.Location = new System.Drawing.Point(323, 180);
            this.textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            this.textBoxKorisnickoIme.Size = new System.Drawing.Size(188, 20);
            this.textBoxKorisnickoIme.TabIndex = 9;
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLozinka.Location = new System.Drawing.Point(320, 220);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(67, 16);
            this.labelLozinka.TabIndex = 10;
            this.labelLozinka.Text = "Password";
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxLozinka.Location = new System.Drawing.Point(323, 250);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(188, 20);
            this.textBoxLozinka.TabIndex = 11;
            // 
            // buttonRegistracija
            // 
            this.buttonRegistracija.Location = new System.Drawing.Point(323, 360);
            this.buttonRegistracija.Name = "buttonRegistracija";
            this.buttonRegistracija.Size = new System.Drawing.Size(188, 23);
            this.buttonRegistracija.TabIndex = 14;
            this.buttonRegistracija.Text = "Register";
            this.buttonRegistracija.UseVisualStyleBackColor = true;
            this.buttonRegistracija.Click += new System.EventHandler(this.buttonRegistracija_Click);
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrijava.Location = new System.Drawing.Point(323, 317);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(188, 23);
            this.buttonPrijava.TabIndex = 12;
            this.buttonPrijava.Text = "Log in";
            this.buttonPrijava.UseVisualStyleBackColor = true;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
            // 
            // linkLabelLozinka
            // 
            this.linkLabelLozinka.AutoSize = true;
            this.linkLabelLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLozinka.Location = new System.Drawing.Point(420, 282);
            this.linkLabelLozinka.Name = "linkLabelLozinka";
            this.linkLabelLozinka.Size = new System.Drawing.Size(91, 13);
            this.linkLabelLozinka.TabIndex = 13;
            this.linkLabelLozinka.TabStop = true;
            this.linkLabelLozinka.Text = "Forgot password?";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "Hrvatski",
            "English"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(667, 40);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLanguage.TabIndex = 30;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.buttonRegistracija);
            this.Controls.Add(this.linkLabelLozinka);
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.labelLozinka);
            this.Controls.Add(this.textBoxKorisnickoIme);
            this.Controls.Add(this.labelKorisnickoIme);
            this.Controls.Add(this.labelDobrodosli);
            this.Name = "LoginForm";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

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

