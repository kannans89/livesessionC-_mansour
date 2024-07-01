namespace _03OverloadingApp
{
	internal class Program
	{
		static void Main(string[] args)
		{

			PrintInfo("hello");
			PrintInfo("#a");
			PrintInfo('a');
			PrintInfo(3);
			PrintInfo(3f);


		}

	   static	void PrintInfo(string input)
		{
			Console.WriteLine($"(1) printing string value {input}");
		}

		static void PrintInfo(char input)
		{
			Console.WriteLine($"(2) printing character value {input}");
		}

		static void PrintInfo(float input)
		{
			Console.WriteLine($"(3) printing float value {input}");
		}

		static void PrintInfo(int input)
		{
			Console.WriteLine($"(4) printing int value {input}");
		}
	}
}
