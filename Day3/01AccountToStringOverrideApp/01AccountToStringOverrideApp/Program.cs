using _01AccountToStringOverrideApp.Model;

namespace _01AccountToStringOverrideApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//CaseStudy1();

			Account obj1 = new Account(101, "Ahmad", 5000);

            Console.WriteLine(obj1.ToString());
        }

		private static void CaseStudy1()
		{
			Account obj1 = new Account(101, "Ahmad", 5000);
			Account obj2 = new Account(102, "Kannan", 4000);

			Account obj3 = new Account();

			Console.WriteLine("hashcode of obj1 " + obj1.GetHashCode());
			Console.WriteLine("hashcode of obj2 " + obj2.GetHashCode());
			Console.WriteLine("hashcode of obj3 " + obj3.GetHashCode());
		}
	}
}
