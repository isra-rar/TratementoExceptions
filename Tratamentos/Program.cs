using System;
using Tratamentos.Entitites;
using Tratamentos.Exceptions;

namespace Tratamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Israel", 500.00, 250);
            try
            {
                account.Withdraw(251);

                Console.WriteLine(account.Balance);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
