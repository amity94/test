using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("enter a number");
			int x = int.Parse(Console.ReadLine());
			multiple2(ref x);// I added the "ref" word
			Console.WriteLine($"your number multiplied by 2 is {x}");
		}

		static void multiple2(ref int i)// I added the "ref" word
		{
			i = i * 2;
		}
	}

}
