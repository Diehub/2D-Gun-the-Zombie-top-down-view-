using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GunZombie
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			
			// Show testDialog as a modal dialog and determine if DialogResult = OK.
			//Interaction.InputBox("Question?", "Title", "Default Text");
			

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
		
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//public PictureBox TheChar() {
			//get{ return this.pictureBox1; }
		//}
	}
}
