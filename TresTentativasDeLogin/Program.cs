using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha, user;
            int i = 0;

            Console.WriteLine("Digite o usuário: ");
            user = Console.ReadLine();
            Console.WriteLine("Digite a senha: ");
            senha = Console.ReadLine();


            if (user == "admin" && senha == "aq123")
            {
                Console.WriteLine("Você acessou o sistema.");
                Console.ReadLine();
            }
            else
            {
                do
                {
                    Console.WriteLine("Dados incorretos. Você tem " + (2 - i) + " tentativas restantes");
                    Console.WriteLine("Digite o usuário: ");
                    user = Console.ReadLine();
                    Console.WriteLine("Digite a senha: ");
                    senha = Console.ReadLine();
                    i++;
                } while (user != "admin" && senha != "aq123" && i <= 1);

                if (user == "admin" && senha == "aq123")
                {
                    Console.WriteLine("Você acessou o sistema.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Acesso bloqueado");
                    Console.ReadLine();
                }
                
            }

        }
    }
}