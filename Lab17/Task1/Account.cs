using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Account<T>
    {
        T number;
        decimal balance;
        string name;

        public void SetNumber(T number) => this.number = number;

        public T GetNumber() => number;

        public void SetName(string name) => this.name = name;
        public string GetName() => name;

        public void SetBalance(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Баланс не может быть меньше нуля.");
            }
            balance = amount;
        }
        public decimal GetBalance() => balance;

        public string GetInfo()
        {
            return $"Аккаунт номер {GetNumber()}\nКлиент: {GetName()}\nБаланс: {GetBalance()}";
    }
    }
}
