

using _02AccountEncapsulationApp.Model;

namespace _02AccountEncapsulationApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//CaseStudy1();

			//CaseStudy2();

			Account acc1 = new Account();
			acc1.Name = "Ahmad";
			acc1.Deposit(500);
			acc1.AccountNumber = 1001;

			Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc1.GetType());
            Console.WriteLine(acc1.GetHashCode());

        }

		private static void CaseStudy2()
		{
			Account acc1 = new Account();
			acc1.Name = "John";
			acc1.AccountNumber = 1001;

			Account acc2 = acc1;

			PrintInfo(acc1);
			PrintInfo(acc2);

			acc2.Deposit(500);

			Console.WriteLine("after deposit");
			PrintInfo(acc1);
			PrintInfo(acc2);


			Console.WriteLine(acc1.GetHashCode());
			Console.WriteLine(acc2.GetHashCode());

			Account acc3 = new Account();
			Console.WriteLine(acc3.GetHashCode());
		}

		private static void CaseStudy1()
		{
			Account account = new Account();

			account.Name = "John";

			account.AccountNumber = 1001;
			account.Deposit(5000);
			PrintInfo(account);

			account.Deposit(1000);
			PrintInfo(account);

			account.Withdraw(6000);
			PrintInfo(account);


			Console.WriteLine("end of main");
		}

		static void PrintInfo(Account account)
		{
			Console.WriteLine($"Account Number: {account.AccountNumber}");
			Console.WriteLine($"Balance: {account.Balance}");
            Console.WriteLine($"Nameis  {account.Name}");
        }
	}
}
