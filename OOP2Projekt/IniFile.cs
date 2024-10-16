using System.Runtime.InteropServices;
using System.Text;

namespace OOP2Projekt
{
    public class IniFile
    {
        private string _filePath;

        [DllImport("kernel32", CharSet = CharSet.Auto)]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Auto)]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        public IniFile(string filePath)
        {
            _filePath = filePath;
        }

        // Metoda za čitanje iz INI datoteke
        public string Read(string section, string key)
        {
            var retVal = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", retVal, 255, _filePath);
            return retVal.ToString();
        }

        // Metoda za pisanje u INI datoteku
        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, _filePath);
        }
    }
}
