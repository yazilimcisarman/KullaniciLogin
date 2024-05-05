using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logine hoşgeldiniz.");
            Console.WriteLine("KullanıcıAdınızı/Telefon Numaranızı/Mailinizi giriniz.");
            string mail = "sarman@gmail.com";
            string phoneNumber = "1234567891";
            string userName = "Sarman";

            string user = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz.");
            string userPassword = Console.ReadLine();
            string password = "Sarman123.";

            if(mail == user || userName == user || phoneNumber == user)
            {
                if(userPassword == password)
                {
                    Console.WriteLine("Giriş Yapıldı.");
                }
                else
                {
                    Console.WriteLine("Şifreniz hatalı");
                }
            }
            else
            {
                Console.WriteLine("Kullanıcı adınızı/telefon numaranızı/ mailinizi kontrol edin");
            }
            Console.ReadLine();
        }
    }
}
