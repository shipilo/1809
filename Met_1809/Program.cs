using System;

namespace Met_1809
{
    class Program
    {
        public enum AccountType
        {
            Current,
            Saving
        }

        public struct Account
        {
            public int index;
            public AccountType accountType;
            public int balance;

            public string OutPut()
            {
                return ($"Номер: {index}\nТип: {accountType}\nБаланс: {balance}\n");
            }
        }

        enum University
        {
            КГУ,
            КАИ,
            КХТИ
        }

        struct Employee
        {
            public string name;
            public University university;
            public string OutPut()
            {
                return $"Имя: {name}\nВуз: {university}\n";
            }

        }

        static void Main(string[] args)
        {
            //3.1
            AccountType type;
            type = AccountType.Current;
            Console.WriteLine(type + "\n");

            //3.2
            Account account1, account2, account3;
            account1.index = 1;
            account1.accountType = AccountType.Current;
            account1.balance = 10000;
            account2.index = 2;
            account2.accountType = AccountType.Saving;
            account2.balance = 0;
            account3.index = 3;
            account3.accountType = AccountType.Current;
            account3.balance = 500;
            Console.WriteLine(account1.OutPut());
            Console.WriteLine(account2.OutPut());
            Console.WriteLine(account3.OutPut());

            //3.1
            Employee employee1, employee2, employee3;
            employee1.name = "Иван Иванович";
            employee1.university = University.КАИ;
            employee2.name = "Василий Васильевич";
            employee2.university = University.КГУ;
            employee3.name = "Артём Артёмович";
            employee3.university = University.КХТИ;
            Console.WriteLine(employee1.OutPut());
            Console.WriteLine(employee2.OutPut());
            Console.WriteLine(employee3.OutPut());


            Console.ReadLine();
        }
    }
}
