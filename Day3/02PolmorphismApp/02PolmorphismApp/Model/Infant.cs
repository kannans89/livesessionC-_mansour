using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PolmorphismApp.Model
{
	internal class Infant:Man
	{

		public override void Play()
		{
            Console.WriteLine("INfant is playing");
        }
	}
}
