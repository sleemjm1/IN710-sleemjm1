using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionTool
{
    class Rot : IEncrypt
    {
        public string PerformEncryption(string stringToEncrypt)
        {
            char[] charArray = stringToEncrypt.ToCharArray();
            int max = charArray.Length;

            for (int i = 0; i < max; i++)
            {
                int charNum = (int)charArray[i]; // Cast to int
                //              97                122
                if (charNum >= 'a' && charNum <= 'z')   // if our number is between 97-122 then it is lowercase
                {
                    if (charNum > 'm') charNum -= 13;   // charNum > 109 then we will decrement by 13 to get to our conversion 
                    else charNum += 13;                 // else we need to add 13 to get to our conversion
                }
                else if (charNum >= 'A' && charNum <= 'Z') // same thing for uppercase 
                {
                    if (charNum > 'M') charNum -= 13;
                    else charNum += 13;
                }
                charArray[i] = (char)charNum;    // Cast back

            }
            string returnString = new string(charArray); // Wow this is great
            return returnString;
        }
    }
}
