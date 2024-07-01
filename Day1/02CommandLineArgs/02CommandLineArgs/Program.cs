namespace _02CommandLineArgs
{
	internal class Program
	{
		static void Main(string[] args)
		{

			if (args.Length>0) { 
			
				foreach(string name in args)
				{
					Console.WriteLine("Hello, " + name);
				}
			
			}
            else
            {
                Console.WriteLine("No arguments passed to say hello");
            }
        }
	}
}
