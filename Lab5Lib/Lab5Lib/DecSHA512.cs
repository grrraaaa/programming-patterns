using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Lib
{
    public class DecSHA512 : Decorator
    {
        public DecSHA512(IWriter writer) : base(writer) { }

        public override string? Save(string massage)
        {
            using (var sha512 = SHA512.Create()) // чтобы не исп Dispose для освобождения ресурсов
            {
                var data = Encoding.UTF8.GetBytes(massage ?? string.Empty);
                var hashedData = sha512.ComputeHash(data);
                var hashedMessage = Convert.ToBase64String(hashedData);
                var decoratedMessage = $"{massage}{Constant.Delimitr}{hashedMessage}";
                return writer?.Save(decoratedMessage);
            }
        }
    }
}
