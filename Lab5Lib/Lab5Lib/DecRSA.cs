using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Lib
{
    public class DecRSA : Decorator
    {
        public DecRSA(IWriter? writer) : base(writer)
        {
        }
        public override string? Save(string? message)
        {
            string publicKey;
            byte[] encyptData;
            message = message ?? string.Empty;
            int index = message.IndexOf(Constant.Delimitr);
            if (index == -1) throw new Exception("Delimitr not found");
            string temp = message.Substring(0, index);
            string temp2 = message.Substring(index + 1);
            byte[] temp3 = Convert.FromBase64String(temp2);
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())  //чтобы не использовать Dispose чтобы освободить ресурсы
            {
                publicKey = rsa.ToXmlString(true);
                rsa.ImportParameters(rsa.ExportParameters(false)); //параметры RSA 
                encyptData = rsa.Encrypt(temp3, false); //шифровка false = прямое шифрование без паддинга
            }
            string result = $"{temp}{Constant.Delimitr}{Convert.ToBase64String(encyptData)}{Constant.Delimitr}{publicKey}";
            return writer?.Save(result);
        }
    }
}
