using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PolmorphismApp.Model
{
	internal class Man
	{

		private void Foo()
		{
			Console.WriteLine("foo");
		}

		public virtual void Play() {

            Console.WriteLine("Man is playing.. ");
        }

		public void Read() {
            Console.WriteLine("Man is reading");
        }
	}
}
