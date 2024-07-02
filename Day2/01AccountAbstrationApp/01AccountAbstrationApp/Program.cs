
using _01AccountAbstrationApp.Model;

namespace _01AccountAbstrationApp
{
	internal class Program
	{
		static void Main()
		{
			//CaseStudy1();

			Account acc1 = new Account();
			acc1.balance = -1000;

            PrintInfo(acc1);


        }

		private static void CaseStudy1()
		{
			Account acc1 = null;// acc expects an object of account class
			acc1 = new Account();

			PrintInfo(acc1);

			acc1.accoutNumber = 101;
			acc1.name = "Ravi";
			acc1.balance = 1000;

			PrintInfo(acc1);

			Account acc2 = new Account();
			acc2.accoutNumber = 102;
			acc2.name = "Ahmad";
			acc2.balance = 2000;

			PrintInfo(acc2);
		}

		static void PrintInfo(Account account) {


			Console.WriteLine("acc name is :" + account.name);
			Console.WriteLine("balance is :" + account.balance);
			Console.WriteLine("account no is :" + account.accoutNumber);
            Console.WriteLine("====================");
        }
	}
}
