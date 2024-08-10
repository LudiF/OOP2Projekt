using System;
using OOP2Projekt;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2Projekt
{
    public partial class GlavnaForma : Form, ILocalizable
    {
        public GlavnaForma()
        {
            InitializeComponent();
            LanguageSettings.OnLanguageChanged += LanguageChangedHandler; // Pretplata na događaj
            SetLanguage(LanguageSettings.CurrentLanguage);
        }

        private void LanguageChangedHandler(object sender, EventArgs e)
        {
            SetLanguage(LanguageSettings.CurrentLanguage); // Ažuriraj jezik kad se događaj pokrene
        }

        public void SetLanguage(string langCode) // Promijenite u public
        {
            // Inicijalizirajte cultureInfo i resManager
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(langCode);
            ResourceManager resManager = new ResourceManager("OOP2Projekt.Resources", typeof(GlavnaForma).Assembly);

            // Ažurirajte UI elemente
            this.Text = resManager.GetString("MainFormTitle", cultureInfo);
            // Postavite ispravnu vrijednost u ComboBox-u
            comboBoxLanguage.SelectedItem = langCode == "hr" ? "Hrvatski" : "English";
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Odjavite se s događaja kada se forma zatvori
            LanguageSettings.OnLanguageChanged -= LanguageChangedHandler;
            base.OnFormClosed(e);
        }
    }

}
