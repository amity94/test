using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{

			int[] arraya, arrayb;
			arraya = new[] { 8, 7,  };
			arrayb = new[] { 3, 10 };

			Console.WriteLine(Measure(ref arraya, ref arrayb));

		}

		static int Measure(ref int[] arraya, ref int[] arrayb)
		{
			int points = 0;
			int result = 0;
			int i = arraya[0];
				if (arraya[i] > arrayb[i])
				{
					result = 1;
					i++;
				points++;
				}
				else if (arraya[i] == arrayb[i])
				{
					result = 0;
					i++;
				}
				else if (arraya[i] < arrayb[i])
				{
					result = -1;
					i++;
				points--;
				}
			
			return result;
		}
	}
}
