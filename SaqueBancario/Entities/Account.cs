using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaqueBancario.Exception;

namespace SaqueBancario.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }

        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Saque(double sake)
        {
            if (WithDrawLimit < sake) throw new DomainExeception("Limite Insuficiente !!");
            if (sake > Balance) throw new DomainExeception("Saldo Insuficiente !!");


            Balance -= sake;
          
        }

        public override string ToString()
        {
            return $"{Balance:f2}";
        }
    }
}
