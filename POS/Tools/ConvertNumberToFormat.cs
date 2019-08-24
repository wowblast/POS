using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Tools
{
    public class ConvertNumberToFormat
    {
        public static string ConvertNumberToReceiptFormat(int number, int stringLength)
        {
            string numberWithFormat = number.ToString();

            if (number.ToString().Length < stringLength)
            {
                for (int i = 0; i < stringLength - number.ToString().Length; i++)
                {
                    numberWithFormat = "0" + numberWithFormat;
                }
            }

            return numberWithFormat;
        }
    }
}
