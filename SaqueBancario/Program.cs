using SaqueBancario.Entities;
using SaqueBancario.Exception;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int.TryParse(Console.ReadLine(), out int number);
            Console.Write("Holder: ");
            string holder = Console.ReadLine(); 
            Console.Write("Initial balance: ");
            double.TryParse(Console.ReadLine(), out double balance);
            Console.Write("Withdraw Limit: ");
            double.TryParse(Console.ReadLine(), out double withDraw);

            Account account = new Account(number,holder,balance,withDraw);
            try
            {
                Console.Write("Enter amount for withdraw: ");
                double.TryParse(Console.ReadLine(), out double amount);
                account.Saque(amount);


            }
            catch (DomainExeception e) {
                Console.WriteLine($"Erro: {e.Message}");
            }


            Console.WriteLine($"Valor att: {account}");

        }
    }
}
