using System;

namespace Assignment3
{

    public class Accounts
    {
        public int AccountNo;
        public string CustomerName;
        public string AccountType;
        public int Amount;
        public int Balance;

        public Accounts(int accno, string cusname, string accType, int bal)
        {
            AccountNo = accno;
            CustomerName = cusname;
            AccountType = accType;
            Balance = bal;

        }
        public void Display()
        {
            Console.WriteLine("Account No: " + AccountNo);
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Account Type: " + AccountType);
            Console.WriteLine("Amount(D or W): " + Amount);
            Console.WriteLine("Balance: " + Balance);
        }
    }
    class Deposits : Accounts
    {
        public Deposits(int accno, string cusname, string accType, int bal) : base(accno, cusname, accType, bal)
        {
        }
        public void MakeDeposits()
        {

            Console.WriteLine("Enter the Amount to make Deposits");
            try
            {
                Amount = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Enter a valid Number");
                MakeDeposits();
            }
            if (Amount > 0)
            {
                Balance += Amount;
                Console.WriteLine("Amount deposited successfully. New balance: " + Balance);
            }
            else
            {
                Console.WriteLine("Please Enter the Deposit Amount Greater than 0");
                MakeDeposits();
            }
        }

        public void MakeWithdrawal()
        {
            Console.WriteLine("Enter the Withdrawal Amount");
            try
            {
                Amount = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Enter a Valid Number");
                MakeWithdrawal();
            }
            if (Amount > 0)
            {
                if (Balance < Amount)
                {
                    Console.WriteLine("Insufficient balance for withdrawal.");

                }
                else
                {
                    Balance -= Amount;
                    Console.WriteLine("Amount Withdrawn Successfully.New balance:" + Balance);
                }
            }
            else
            {
                Console.WriteLine("Withdrawal Amount must be Greater than Zero");
                MakeWithdrawal();
            }
        }
        class Program
        {
            public static void Main()
            {
                Console.WriteLine("Enter the Account No:");
                int AccountNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the CustomerName:");
                string CustomerName = Console.ReadLine();
                Console.WriteLine("Enter the Account Type");
                string AccountType = Console.ReadLine();
                Console.WriteLine("Enter the Balance");
                int Balance = Convert.ToInt32(Console.ReadLine());


                Deposits d = new Deposits(AccountNo, CustomerName, AccountType, Balance);
                Console.WriteLine("Enter the TransactionType D for Deposits and W for Withdrawal");
                string TransactionType;
                TransactionType = Console.ReadLine();
                if (TransactionType == "d" || TransactionType == "D")
                {
                    d.MakeDeposits();
                }
                else if (TransactionType == "w" || TransactionType == "W")
                {
                    d.MakeWithdrawal();
                }
                else
                {
                    Console.WriteLine("Invalid Transaction Type");
                }
                d.Display();

            }
        }
    }
}




