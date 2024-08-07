using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2Projekt
{
    public partial class LoginForm : Form
    {
        ResourceManager resManager;
        CultureInfo cultureInfo;
        public LoginForm()
        {
            InitializeComponent();
            SetLanguage("en");
        }

        private void SetLanguage(string langCode)
        {
            cultureInfo = CultureInfo.CreateSpecificCulture(langCode);
            resManager = new ResourceManager("OOP2Projekt.Resources", typeof(LoginForm).Assembly);

            // Update UI elements with resource values
            this.Text = resManager.GetString("LoginFormTitle", cultureInfo);
            labelKorisnickoIme.Text = resManager.GetString("LabelUsername", cultureInfo);
            labelLozinka.Text = resManager.GetString("LabelPassword", cultureInfo);
            buttonPrijava.Text = resManager.GetString("ButtonLogin", cultureInfo);
            buttonRegistracija.Text = resManager.GetString("ButtonRegister", cultureInfo);
            linkLabelLozinka.Text = resManager.GetString("LabelPassword", cultureInfo);
            // Add other UI elements here
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
        }

        private void buttonRegistracija_Click(object sender, EventArgs e)
        {
            RegistracijskaForma registrationForm = new RegistracijskaForma();
            registrationForm.Show();
        }
        private void SwitchLanguage(string langCode)
        {
            SetLanguage(langCode);
        }
        private void comboBoxLanguage_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedLanguage = comboBoxLanguage.SelectedItem.ToString();
            if (selectedLanguage == "Hrvatski")
            {
                SwitchLanguage("hr");
            }
            else if (selectedLanguage == "English")
            {
                SwitchLanguage("en");
            }
        }
    }
}
