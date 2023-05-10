using ENTITIES;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES
{
    public class ToolService
    {
        public static bool KiemTraKetNoi()
        {
            var db = new MyShopContext();
            try
            {
                db.Users.ToList();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static string Entropy()
        {
            Byte[] entropy = new Byte[20];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(entropy);
            }
            return Convert.ToBase64String(entropy);
        }
        public static void TaoRegistry()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MyShopSettings");
            key.SetValue("Username", "");
            key.SetValue("Password", "");
            key.SetValue("Check", "0");
            key.SetValue("Entropy", "");
            key.Close();
        }
        public static void Encode (string password)
        {
            Byte[] entropy = new Byte[20];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(entropy);
            }
            var passwordInBytes = Encoding.UTF8.GetBytes(password);
            var encodePassword = ProtectedData.Protect(passwordInBytes, entropy, DataProtectionScope.CurrentUser);
            var temp = DataProtectionScope.CurrentUser;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MyShopSettings", true);
            key.SetValue("Password", Convert.ToBase64String(encodePassword));
            key.SetValue("Entropy", Convert.ToBase64String(entropy));
            key.Close();
        }

        public static string Decode (string encodePassword, string entropy)
        {
            var passwordInBytes = Convert.FromBase64String(encodePassword);
            var entropyInBytes = Convert.FromBase64String(entropy);
            var temp = DataProtectionScope.CurrentUser;
            var password = ProtectedData.Unprotect(passwordInBytes, entropyInBytes, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(password);
        }
    }
}
