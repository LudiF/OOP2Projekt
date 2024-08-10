using System;
using OOP2Projekt;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Projekt
{
    public static class LanguageSettings
    {
        private static string currentLanguage = "en";

        public static string CurrentLanguage
        {
            get => currentLanguage;
            set
            {
                if (currentLanguage != value)
                {
                    currentLanguage = value;
                    OnLanguageChanged?.Invoke(null, EventArgs.Empty);
                }
            }
        }

        public static event EventHandler OnLanguageChanged;
    }
}
