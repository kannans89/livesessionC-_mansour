﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PolmorphismApp.Model
{
	internal class Boy:Man
	{

		public override void Play() {

            Console.WriteLine("Boy is playing..");
        }

		public void Eat() {

            Console.WriteLine("Boy is eating...");
        }
	}
}
