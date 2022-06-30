using Polymorfizm.Models;
using System;

namespace Polymorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "test";
            string pass = "Cavid123";

            Account account = new Account();

            bool isLogged = account.Login(email, pass);

            isLogin(isLogged);
        }




        public static void isLogin(bool isLogin)
        {
            if (isLogin)
            {
                Console.WriteLine("Succes Login");
                return;
            }

            Console.WriteLine("Password or email is wrong");
        }
    }
}
