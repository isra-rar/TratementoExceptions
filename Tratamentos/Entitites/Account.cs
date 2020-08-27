﻿
using Tratamentos.Exceptions;

namespace Tratamentos.Entitites
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if(amount > Balance)
            {
                throw new DomainException("Saldo em conta insuficiente!");
            } else if (amount > WithdrawLimit)
            {
                throw new DomainException("Limite de saque insuficiente!");
            }
            Balance -= amount;
        }
    }
}
