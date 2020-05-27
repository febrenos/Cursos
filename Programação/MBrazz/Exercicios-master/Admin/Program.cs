using System;

namespace Admin
{
    class Program
    {
        static void Main(string[] args)
        {
            string admLogin = "admin";
            string admPasswd = "admin";


            Console.Write("Entre com o usuário: ");
            string login = Console.ReadLine();
            Console.Write("Entre com a senha: ");
            string passwd = Console.ReadLine();

           if ((login == admLogin) && (passwd == admPasswd)){
               Console.WriteLine("Bem vindo Admin.");
           } else{
               Console.WriteLine("Olá usuário.");
           }

        }
    }
}