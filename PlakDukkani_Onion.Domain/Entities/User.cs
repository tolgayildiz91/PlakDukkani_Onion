using PlakDukkani_Onion.Domain.Entities.Abstract;
using PlakDukkani_Onion.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani_Onion.Domain.Entities
{
    public class User : BaseEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                if (IsValidPassword(value) == true)
                {
                    _password = sha256_hash(value);
                }

                else
                {
                    throw new Exception("Şifre Güvenli Değil");
                }
            }

        }
        static bool IsValidPassword(string password)
        {
            int upperCase = 0, lowerCase = 0, specialChars = 0;

            if (password.Length <= 8)
                return false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    upperCase++;
                else if (char.IsLower(c))
                    lowerCase++;
                else if (c == '!' || c == ':' || c == '+' || c == '*')
                    specialChars++;
            }

            return upperCase >= 2 && lowerCase >= 3 && specialChars >= 2;
        }

        public string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }


    }

}
