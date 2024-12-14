using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Lib
{
    public class DecMD5 : Decorator
    {
        public DecMD5(IWriter? writer) : base(writer)
        { }
            public override string? Save(string? message)
        {
            using (var md5 = MD5.Create()) //чтобы не исп Dispose для осв ресов
            {
                var data = Encoding.UTF8.GetBytes(message ?? string.Empty); //вернёт массив байтов
                var encryptData = md5.ComputeHash(data); //хэш длинной 16 байт
                var hashedMessage = Convert.ToBase64String(encryptData); //переведет в строку , 6 бит=1 символ 
                var decoratedMessage = $"{message}{Constant.Delimitr}{hashedMessage}";
                return writer?.Save(decoratedMessage);
            }
            }
        
        }
    }

