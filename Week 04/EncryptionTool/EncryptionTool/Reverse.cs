using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionTool
{
    class Reverse : IEncrypt
    {
        public string PerformEncryption(String stringToEncrypt)
        {
            char[] charArray = stringToEncrypt.ToCharArray(); //convert string to array of chars
            int max = charArray.Length-1; // Length -1 because 0 based
            string returnString = "";   //string that we will build/return
           
            int count = 0;
            for (int i = max; i > -1; i--) // Go through array backwards
            {
                returnString += charArray[i]; // Add to our string
                count++;
            }
            return returnString;    // Return our fully built string
        }
    }
}
