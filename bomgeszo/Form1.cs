using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bomgeszo
{
	
	public partial class Form1 : Form
	{
		int n = 1;
		public Form1()
		{
			InitializeComponent();
			webBrowser1.ScriptErrorsSuppressed = true;
		}

		private void back_Click(object sender, EventArgs e)
		{
			webBrowser1.GoBack();
		}

		private void fore_Click(object sender, EventArgs e)
		{
			webBrowser1.GoForward();
		}

		private void refresh_Click(object sender, EventArgs e)
		{
			webBrowser1.Refresh();
		}

		private void go_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate(txtAddress.Text);
		}

		private void txtAddress_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void txtAddress_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				webBrowser1.Navigate(txtAddress.Text);
			}
		}

		private void newTab_Click(object sender, EventArgs e)
		{
			

		}
	}
}
