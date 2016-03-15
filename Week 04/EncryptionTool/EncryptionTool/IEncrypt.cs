﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionTool
{
    public interface IEncrypt
    {
        String PerformEncryption(String stringToEncrypt);
        String PerformDecryption(String stringToDecrypt);
    }
}
