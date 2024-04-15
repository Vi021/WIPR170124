using BCrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR170124
{
    internal class PassHasher
    {
        string password;
        
        public PassHasher(string pass="")
        {
            if (pass != "")
            {
                password = pass;
            }
        }

        public string getHashedPass()
        {
            return password;
        }

        string passHasher(string password)
        {
            if (password != "")
            {
                //return BCrypt.Net.BCrypt.HashPassword(password);      //same pass return difference hash!

                long hashedPass = 0;
                for (int i = 0; i < password.Length; i++)
                {
                    hashedPass += (int)password[i] * (int)Math.Pow(i+1, 3);
                }
                return hashedPass.ToString();
            }
            else
            {
                return password;
            }
        }


        private const int SaltSize = 16; // 128 bits
        private const int HashSize = 20; // 160 bits
        private const int Iterations = 10000; // recommended minimum number of iterations

        public string HashPassword(string password)
        {
            // Generate a random salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

            // Hash the password and salt using PBKDF2
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            // Combine the salt and hash
            byte[] hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            // Convert to base64 string
            string base64Hash = Convert.ToBase64String(hashBytes);

            return base64Hash;
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            // Extract the salt and hash from the stored password
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);
            byte[] salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);
            byte[] hash = new byte[HashSize];
            Array.Copy(hashBytes, SaltSize, hash, 0, HashSize);

            // Compute the hash of the provided password using the stored salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            byte[] testHash = pbkdf2.GetBytes(HashSize);

            // Compare the computed hash with the stored hash
            for (int i = 0; i < HashSize; i++)
            {
                if (hash[i] != testHash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
