using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Tools
{
    public class FileUtil
    {
        public static readonly string textFile = "settings.txt";

        public static int Read()
        {
            int number = 0;

            if (File.Exists(textFile))
            {
                string text = File.ReadAllText(textFile);
                text = text.Substring(text.IndexOf(":") + 1).Replace(" ", string.Empty);
                number = int.Parse(text);
            }
            else
            {
                MessageBox.Show("No se ha encontrado el archivo settings");
            }
            return number;
        }

        public static void Write()
        {
            int newNumber = Read() + 1;

            File.Delete(textFile);

            File.WriteAllText(textFile, "Numero recibo: " + newNumber);
        }
    }
}
