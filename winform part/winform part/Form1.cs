using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_part
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		
		

		private void startbtn_Click(object sender, EventArgs e)
		{
			label1.Visible = false;
			label2.Visible = false;
			label3.Visible = false;
			label4.Visible = false;
			label5.Visible = false;

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Random r = new Random();
			label1.Text = r.Next(0, 101).ToString();
			label2.Text = r.Next(0, 101).ToString();
			label3.Text = r.Next(0, 101).ToString();
			label4.Text = r.Next(0, 101).ToString();
			label5.Text = r.Next(0, 101).ToString();
		}

		private void finishbtn_Click(object sender, EventArgs e)
		{
			if (label1.Text != textBox1.Text)
			{
				textBox1.BackColor = Color.Red;
				label1.BackColor = Color.Red;
			}
			if (label2.Text != textBox2.Text)
			{
				textBox2.BackColor = Color.Red;
				label2.BackColor = Color.Red;
			}
			if (label3.Text != textBox3.Text)
			{
				textBox3.BackColor = Color.Red;
				label3.BackColor = Color.Red;
			}
			if (label4.Text != textBox4.Text)
			{
				textBox4.BackColor = Color.Red;
				label4.BackColor = Color.Red;
			}
			if (label5.Text != textBox5.Text)
			{
				textBox5.BackColor = Color.Red;
				label5.BackColor = Color.Red;
			}
			if (label1.Text == textBox1.Text && label2.Text == textBox2.Text && label3.Text == textBox3.Text && label4.Text == textBox4.Text && label5.Text == textBox5.Text)
			{
				MessageBox.Show("you won!","congratulations!" , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("wrong", "oopsy", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			if(MessageBox.Show("Are you sure you want to exit?", "Exit" , MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
			DialogResult.OK)
			{
				Application.Exit();
			}
		}

		private void newGaneToolStripMenuItem_Click(object sender, EventArgs e)
		{
			label1.Visible = true;
			label2.Visible = true;
			label3.Visible = true;
			label4.Visible = true;
			label5.Visible = true;

			Random r = new Random();
			label1.Text = r.Next(0, 101).ToString();
			label2.Text = r.Next(0, 101).ToString();
			label3.Text = r.Next(0, 101).ToString();
			label4.Text = r.Next(0, 101).ToString();
			label5.Text = r.Next(0, 101).ToString();

			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			listBox1.Items.Clear();
		}

		//i don't know how to do the listbox part
		// question 2. why do we need to use Debug.WriteLine in WinFomrs?
		// answer 2. because we can't call the "Console". if we want to get a feedback that something is happening correctly we need to call the "Debug" window instead of "Console"
		//question 3.  מדוע במתודות בהם היינו צריכים להדפיס מספר רכיבים בהשהייה הוספנו new thread?
		// answer 3. when using threads we need to use a new thread so that the UI thread will be able to do it's job simultaneously and show the use the result in real time.
		//question 4. in a job interview, the interviewer tells you the company is working with .NET 2.0
		//answer 4. 1. the company is working with winforms and there haven't been any updates since version 2.0
				  //3. the company wants to use its programs on Linux, and it's known that Mono can only work until version 2.0
	}
}
