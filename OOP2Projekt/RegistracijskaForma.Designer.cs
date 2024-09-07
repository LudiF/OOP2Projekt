using System.Data.SQLite;
using System.Windows.Forms;
using System;

namespace OOP2Projekt
{
    partial class RegistracijskaForma
    {
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            radioButtonZensko = new RadioButton();
            radioButtonMusko = new RadioButton();
            textBoxEmailRegistracija = new TextBox();
            labelSpol = new Label();
            labelEmail = new Label();
            buttonRegistracijaPotvrda = new Button();
            textBoxLozinkaRegistracija = new TextBox();
            labelLozinkaReg = new Label();
            textBoxKorisnickoImeRegistracija = new TextBox();
            labelRegistracijaKorisnickoIme = new Label();
            labelRegistracijaPozdrav = new Label();
            comboBoxLanguage = new ComboBox();
            SuspendLayout();
            // 
            // radioButtonZensko
            // 
            radioButtonZensko.AutoSize = true;
            radioButtonZensko.Location = new System.Drawing.Point(492, 306);
            radioButtonZensko.Margin = new Padding(4, 3, 4, 3);
            radioButtonZensko.Name = "radioButtonZensko";
            radioButtonZensko.Size = new System.Drawing.Size(63, 19);
            radioButtonZensko.TabIndex = 28;
            radioButtonZensko.TabStop = true;
            radioButtonZensko.Text = "Žensko";
            radioButtonZensko.UseVisualStyleBackColor = true;
            // 
            // radioButtonMusko
            // 
            radioButtonMusko.AutoSize = true;
            radioButtonMusko.Location = new System.Drawing.Point(396, 306);
            radioButtonMusko.Margin = new Padding(4, 3, 4, 3);
            radioButtonMusko.Name = "radioButtonMusko";
            radioButtonMusko.Size = new System.Drawing.Size(61, 19);
            radioButtonMusko.TabIndex = 24;
            radioButtonMusko.TabStop = true;
            radioButtonMusko.Text = "Muško";
            radioButtonMusko.UseVisualStyleBackColor = true;
            // 
            // textBoxEmailRegistracija
            // 
            textBoxEmailRegistracija.ForeColor = System.Drawing.SystemColors.GrayText;
            textBoxEmailRegistracija.Location = new System.Drawing.Point(337, 263);
            textBoxEmailRegistracija.Margin = new Padding(4, 3, 4, 3);
            textBoxEmailRegistracija.Name = "textBoxEmailRegistracija";
            textBoxEmailRegistracija.Size = new System.Drawing.Size(226, 23);
            textBoxEmailRegistracija.TabIndex = 23;
            // 
            // labelSpol
            // 
            labelSpol.AutoSize = true;
            labelSpol.Location = new System.Drawing.Point(334, 308);
            labelSpol.Margin = new Padding(4, 0, 4, 0);
            labelSpol.Name = "labelSpol";
            labelSpol.Size = new System.Drawing.Size(33, 15);
            labelSpol.TabIndex = 26;
            labelSpol.Text = "Spol:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new System.Drawing.Point(334, 245);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(41, 15);
            labelEmail.TabIndex = 25;
            labelEmail.Text = "e-mail";
            labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonRegistracijaPotvrda
            // 
            buttonRegistracijaPotvrda.Location = new System.Drawing.Point(337, 352);
            buttonRegistracijaPotvrda.Margin = new Padding(4, 3, 4, 3);
            buttonRegistracijaPotvrda.Name = "buttonRegistracijaPotvrda";
            buttonRegistracijaPotvrda.Size = new System.Drawing.Size(226, 27);
            buttonRegistracijaPotvrda.TabIndex = 27;
            buttonRegistracijaPotvrda.Text = "Registriraj se";
            buttonRegistracijaPotvrda.UseVisualStyleBackColor = true;
            // 
            // textBoxLozinkaRegistracija
            // 
            textBoxLozinkaRegistracija.ForeColor = System.Drawing.SystemColors.GrayText;
            textBoxLozinkaRegistracija.Location = new System.Drawing.Point(337, 209);
            textBoxLozinkaRegistracija.Margin = new Padding(4, 3, 4, 3);
            textBoxLozinkaRegistracija.Name = "textBoxLozinkaRegistracija";
            textBoxLozinkaRegistracija.Size = new System.Drawing.Size(226, 23);
            textBoxLozinkaRegistracija.TabIndex = 21;
            // 
            // labelLozinkaReg
            // 
            labelLozinkaReg.AutoSize = true;
            labelLozinkaReg.Location = new System.Drawing.Point(334, 190);
            labelLozinkaReg.Margin = new Padding(4, 0, 4, 0);
            labelLozinkaReg.Name = "labelLozinkaReg";
            labelLozinkaReg.Size = new System.Drawing.Size(47, 15);
            labelLozinkaReg.TabIndex = 19;
            labelLozinkaReg.Text = "Lozinka";
            // 
            // textBoxKorisnickoImeRegistracija
            // 
            textBoxKorisnickoImeRegistracija.ForeColor = System.Drawing.SystemColors.GrayText;
            textBoxKorisnickoImeRegistracija.Location = new System.Drawing.Point(337, 152);
            textBoxKorisnickoImeRegistracija.Margin = new Padding(4, 3, 4, 3);
            textBoxKorisnickoImeRegistracija.Name = "textBoxKorisnickoImeRegistracija";
            textBoxKorisnickoImeRegistracija.Size = new System.Drawing.Size(226, 23);
            textBoxKorisnickoImeRegistracija.TabIndex = 18;
            // 
            // labelRegistracijaKorisnickoIme
            // 
            labelRegistracijaKorisnickoIme.AutoSize = true;
            labelRegistracijaKorisnickoIme.Location = new System.Drawing.Point(334, 134);
            labelRegistracijaKorisnickoIme.Margin = new Padding(4, 0, 4, 0);
            labelRegistracijaKorisnickoIme.Name = "labelRegistracijaKorisnickoIme";
            labelRegistracijaKorisnickoIme.Size = new System.Drawing.Size(85, 15);
            labelRegistracijaKorisnickoIme.TabIndex = 17;
            labelRegistracijaKorisnickoIme.Text = "Korisničko ime";
            // 
            // labelRegistracijaPozdrav
            // 
            labelRegistracijaPozdrav.AutoSize = true;
            labelRegistracijaPozdrav.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelRegistracijaPozdrav.Location = new System.Drawing.Point(222, 80);
            labelRegistracijaPozdrav.Margin = new Padding(4, 0, 4, 0);
            labelRegistracijaPozdrav.Name = "labelRegistracijaPozdrav";
            labelRegistracijaPozdrav.Size = new System.Drawing.Size(421, 25);
            labelRegistracijaPozdrav.TabIndex = 16;
            labelRegistracijaPozdrav.Text = "Registriraj se i započni pratiti svoje vježbe!";
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Items.AddRange(new object[] { "Hrvatski", "English" });
            comboBoxLanguage.Location = new System.Drawing.Point(778, 50);
            comboBoxLanguage.Margin = new Padding(4, 3, 4, 3);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new System.Drawing.Size(140, 23);
            comboBoxLanguage.TabIndex = 29;
            comboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;
            // 
            // RegistracijskaForma
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(comboBoxLanguage);
            Controls.Add(radioButtonZensko);
            Controls.Add(radioButtonMusko);
            Controls.Add(textBoxEmailRegistracija);
            Controls.Add(labelSpol);
            Controls.Add(labelEmail);
            Controls.Add(buttonRegistracijaPotvrda);
            Controls.Add(textBoxLozinkaRegistracija);
            Controls.Add(labelLozinkaReg);
            Controls.Add(textBoxKorisnickoImeRegistracija);
            Controls.Add(labelRegistracijaKorisnickoIme);
            Controls.Add(labelRegistracijaPozdrav);
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegistracijskaForma";
            Text = "Registracija";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.RadioButton radioButtonZensko;
        private System.Windows.Forms.RadioButton radioButtonMusko;
        private System.Windows.Forms.TextBox textBoxEmailRegistracija;
        private System.Windows.Forms.Label labelSpol;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonRegistracijaPotvrda;
        private System.Windows.Forms.TextBox textBoxLozinkaRegistracija;
        private System.Windows.Forms.Label labelLozinkaReg;
        private System.Windows.Forms.TextBox textBoxKorisnickoImeRegistracija;
        private System.Windows.Forms.Label labelRegistracijaKorisnickoIme;
        private System.Windows.Forms.Label labelRegistracijaPozdrav;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
    }
}