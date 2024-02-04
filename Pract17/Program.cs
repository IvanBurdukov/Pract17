using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pract16
{
    class BankAccount<T>
    {
        private T accountNumber;
        private decimal balance;
        private string ownerName;

        public BankAccount(T accountNumber, decimal balance, string ownerName)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.ownerName = ownerName;
        }

        public void SetAccountInfo(T accountNumber, decimal balance, string ownerName)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.ownerName = ownerName;
        }

        public void PrintAccountInfo()
        {
            Console.WriteLine($"Номер счета: {accountNumber}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Владелец: {ownerName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляров класса BankAccount с различными типами для номера счета
            BankAccount<int> account1 = new BankAccount<int>(123456, 1000.50m, "Иванов Иван Иванович");
            BankAccount<string> account2 = new BankAccount<string>("987654", 20000.75m, "Петров Петр Петрович");
            BankAccount<long> account3 = new BankAccount<long>(9876543210, 500.25m, "Сидоров Сидор Сидорович");

            // Вывод информации о каждом счете
            Console.WriteLine("Информация о счете 1:");
            account1.PrintAccountInfo();
            Console.WriteLine();

            Console.WriteLine("Информация о счете 2:");
            account2.PrintAccountInfo();
            Console.WriteLine();

            Console.WriteLine("Информация о счете 3:");
            account3.PrintAccountInfo();
        }
    }
}