using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Data.Security
{
    public static class EncryptPassword
    {
        static byte[] secretkeyByte = { };

        public static string Encrypt(string Passwoord)
        {
            try
            {
                byte[] textoAsByte = Encoding.ASCII.GetBytes(Passwoord);
                string result = System.Convert.ToBase64String(textoAsByte);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string Decrypt(string Password)
        {
            try
            {
                byte[] dadosAsByte = System.Convert.FromBase64String(Password);
                string result = System.Text.ASCIIEncoding.ASCII.GetString(dadosAsByte);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
	}
}

