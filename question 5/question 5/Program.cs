using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_5
{
	class Program
	{
		static void Main(string[] args)
		{

			//when we don't know how many parameters we want to send to the function, we will use the word "params"
			int[] unknown = { 1, 2, 3}; // now if i want to change how many parameters i have i don't have to go to the function and add a parameter,
			// i can just add a parameter in the array {1,2,3}, or {1,2,3,4} will be OK.
			addsum(unknown);
			
		}

		static void addsum(params int[] a)
		{
			int sum = 0;
			for (int i = 0; i < a.Length; i++)
			{
				sum = sum + a[i];
			}
			Console.WriteLine(sum);
		}
	}
}
