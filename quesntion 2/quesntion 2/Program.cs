using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quesntion_2
{
	class Program
	{
		static void Main(string[] args)
		{

			int[] a = { 5, 4, -5 };
			update(a); // yes, the value will change, becasue the array is defined outside of the function
		}

		static void update(int[] a)
		{
			a[0] = 1;
		}
	}
}
