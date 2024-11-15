using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracKiralama
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text.Equals("Admin") && textBox2.Text.Equals("1903"))
			{
				frmAnaSayfa frmAnaSayfa = new frmAnaSayfa();
				frmAnaSayfa.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Giriş işlemi gerçekleştirilmedi.");
			}

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
