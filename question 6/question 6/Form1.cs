using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace question_6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int[] a = new int[10]; // this code is here and not inside "Form1_Load".

		private void Form1_Load(object sender, EventArgs e)
		{
			//int[] a;
			//a = new int[10];
			/* i put the code outside of the form load so the program always knows what array in trying to build and print in "initialize array" and "print array"
			 */
			InitializeArrays();
			PrintArray();
		}
		private void PrintArray()
		{
			for (int i = 0; i < a.Length; i++)
			{
				Console.WriteLine(a[i]);
			}
		}

		private void InitializeArrays()
		{
			Random r = new Random();
			a = new int[10];
			for (int i = 0; i < 10; i++)
			{
				a[i] = r.Next(101);
			}
		}
	}
}

