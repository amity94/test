using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_3
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] b = { 5, 4, -5 };
			update2(b); //no, the value will not change, because when defining an array inside the function (b=new int[3]) we need to use the "out" word
		}

		static void update2(int[] b)
		{
			b = new int[3];
			b[0] = 1;
		}
	}
}
