using System;

namespace LabExerc1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account log = new Account("eug", 270, 1);
            Console.WriteLine(log.ToString());
            log.Withdraw(1800);
            Console.WriteLine(log);
            //log.Deposit(70);
            //Console.WriteLine(log);
            bool suc = log.Withdraw(1800);
            if (suc == true)
            {
                Console.WriteLine("Successful!");
            }
            else
            {
                Console.WriteLine("Unsuccessful!");
            }

            bool suc2 = log.Deposit(18000);
            if (suc2 == true)
            {
                Console.WriteLine("Successful!");
            }
            else
            {
                Console.WriteLine("Unsuccessful!");
            }

        }
    }
    class Account
    {
        const double depositLimit = 5000;

        public string owner { get; set; }
        public double balance { get; set; }
        public int numberOfTransations { get; set; }

        public Account()
        {

        }
        public Account(string owner, double balance, int numberOfTransations)
        {
            this.owner = owner;
            this.balance = balance;
            this.numberOfTransations = numberOfTransations;
        }

        public override string ToString()
        {
            return "Owner = " + owner + " Balance = " + balance + " numberOfTransations = " + numberOfTransations;
        }

        public bool Withdraw(double amount)
        {
            double z = balance - amount;
            if (z > 0)
            {
                balance -= amount;
                numberOfTransations++;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool Deposit(double amount)
        {
            if (amount > depositLimit)
            {
                balance += amount;
                numberOfTransations++;
                return true;
            }
            else
            {
                return false;
            }

            
        }
    }
}


