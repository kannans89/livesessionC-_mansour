
using _02PolmorphismApp.Model;

namespace _02PolmorphismApp
{
	internal class Program
	{
		static void Main(string[] args)
		{


			//CaseStudy1();

			//CaseStudy2();

			//CaseStudy3();

			//CaseStudy4();

			CaseStudy5();
		}

		private static void CaseStudy5()
		{
			Object parentBox;//Object or subtypes of object

			parentBox = 10.55;

			Console.WriteLine(parentBox.GetType()) ;

			parentBox = "hello";
			Console.WriteLine(parentBox.GetType()) ;

			parentBox = new Man();

			Console.WriteLine(parentBox.GetType());

			Man convertedX = (Man) parentBox;

			convertedX.Play();

		}

		private static void CaseStudy4()
		{
			AtThePark(new Man());
			AtThePark(new Boy());
			AtThePark(new Infant());
			AtThePark(new Toddler());
		}


		//polymorhic
		static void AtThePark(Man man) {

            Console.WriteLine("At the park..");
			man.Play();
        }
		private static void CaseStudy3()
		{
			

			Man x;//ISA

			x = new Boy();

			x.Play();//child behavior must be called
			x.Read();


		}

		private static void CaseStudy2()
		{
			Boy y =new Boy();
			y.Play();
			y.Read();
			y.Eat();
		  
		}

		private static void CaseStudy1()
		{
			Man x = new Man();
			x.Play();
			x.Read();

		}
	}
}
