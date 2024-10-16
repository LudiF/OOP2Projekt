using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace OOP2Projekt
{
    public partial class SettingsForm : Form
    {
        private IniFile iniFile;
        private GlavnaForma glavnaForma;

        public SettingsForm(GlavnaForma glavnaForma)
        {
            InitializeComponent();
            iniFile = new IniFile("appsettings.ini");
            this.glavnaForma = glavnaForma; // Prosljeđujemo referencu na glavnu formu

            // Učitaj trenutne postavke i prikaži ih u kontrolama
            LoadSettings();

            // Povezivanje događaja Click za gumb Save
            buttonSaveSettings.Click += new EventHandler(buttonSaveSettings_Click);
        }

        private void LoadSettings()
        {
            // Učitavanje postavki iz INI datoteke
            string language = iniFile.Read("Settings", "Language");
            string theme = iniFile.Read("Settings", "Theme");

            // Učitavanje postavki iz Windows registra
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\OOP2Projekt");

            // Postavljanje unaprijed odabrane vrijednosti za Language combobox
            if (!string.IsNullOrEmpty(language))
            {
                comboBoxLanguage.SelectedItem = language;
            }
            else
            {
                comboBoxLanguage.SelectedItem = "Hrvatski"; // Ako nije postavljen jezik, postavi na zadanu vrijednost
            }

            // Postavljanje unaprijed odabrane vrijednosti za Theme combobox
            if (!string.IsNullOrEmpty(theme))
            {
                comboBoxTheme.SelectedItem = theme;
            }
            else
            {
                comboBoxTheme.SelectedItem = "Light"; // Ako tema nije postavljena, postavi zadanu temu
            }

            // Učitavanje trenutnih postavki za širinu i visinu prozora iz registra
            if (key != null)
            {
                object widthValue = key.GetValue("WindowWidth");
                object heightValue = key.GetValue("WindowHeight");

                if (int.TryParse(widthValue?.ToString(), out int width))
                {
                    numericUpDownWidth.Value = width;
                }

                if (int.TryParse(heightValue?.ToString(), out int height))
                {
                    numericUpDownHeight.Value = height;
                }
            }
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            // Spremanje postavki u INI datoteku
            if (comboBoxLanguage.SelectedItem != null)
            {
                iniFile.Write("Settings", "Language", comboBoxLanguage.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Molimo odaberite jezik prije spremanja postavki.");
                return;
            }

            if (comboBoxTheme.SelectedItem != null)
            {
                iniFile.Write("Settings", "Theme", comboBoxTheme.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Molimo odaberite temu prije spremanja postavki.");
                return;
            }

            // Spremanje postavki za širinu i visinu prozora u registar
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\OOP2Projekt");
            key.SetValue("WindowWidth", numericUpDownWidth.Value.ToString());
            key.SetValue("WindowHeight", numericUpDownHeight.Value.ToString());
            key.Close();

            // Primijeni postavke odmah na glavnu formu
            glavnaForma.Width = (int)numericUpDownWidth.Value;
            glavnaForma.Height = (int)numericUpDownHeight.Value;

            MessageBox.Show("Postavke su spremljene.");
            this.Close(); // Zatvori formu nakon spremanja
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Zatvori formu bez spremanja
        }
    }
}
