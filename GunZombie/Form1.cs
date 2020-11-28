using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace GunZombie
{
	public partial class Form1 : Form
	{
		Form3 form3 = new Form3();
		bool kanan, kiri, atas, bawah, kalah;
		string arah = "up";
		int pdarah = 100;
		int kecp = 3;
		int zkecp = 1;
		int ammo = 10;
		int nilai;
		Random jml = new Random();
		private PictureBox _thePicture;
		

		List<PictureBox> lzombies = new List<PictureBox>();

		public Form1()
		{
			InitializeComponent();
			this.CenterToScreen();
			Form2 formsec = new Form2();
			formsec.ShowDialog();
			Restart();

			formsec.Close();
		}

		public PictureBox ThePicture
		{
			set { this._thePicture = value; }
			get { return this._thePicture; }
		}

		private void gamePlay(object sender, EventArgs e)
		{

			//if (timer1.Tick = 20) {
			//	pictureBox1.Image = Properties.Resources.ammo_Image;
			//}

			Form2 form2 = new Form2();

			//form2.TheChar = this.ThePicture;

			if (pdarah > 1)
			{
				progressBar1.Value = pdarah;
			}

			else
			{
				kalah = true;
				pictureBox1.Image = Properties.Resources.dead;
				timer1.Stop();
				this.Close();
				form2.Show();
			}

			if (kiri == true && pictureBox1.Left > 0) {
				pictureBox1.Left -= kecp;
			}
			if (kanan == true && pictureBox1.Left + pictureBox1.Width < this.ClientSize.Width) {
				pictureBox1.Left += kecp;
			}
			if (atas == true && pictureBox1.Top > 45)
			{
				pictureBox1.Top -= kecp;
			}
			if (bawah == true && pictureBox1.Top + pictureBox1.Height < this.ClientSize.Height)
			{
				pictureBox1.Top += kecp;
			}

			foreach (Control x in this.Controls) {

				if (x is PictureBox && (string)x.Tag == "ammo") {

					if (pictureBox1.Bounds.IntersectsWith(x.Bounds)) {

						this.Controls.Remove(x);
						((PictureBox)x).Dispose();
						ammo += 5;
					}
					

				}

				if (x is PictureBox && (string)x.Tag == "zombie") {

					if (pictureBox1.Bounds.IntersectsWith(x.Bounds)) {
						pdarah -= 1;
					}

					if (x.Left > pictureBox1.Left) {

						x.Left -= zkecp;
						((PictureBox)x).Image = Properties.Resources.zleft;
					}
					if (x.Left < pictureBox1.Left)
					{

						x.Left += zkecp;
						((PictureBox)x).Image = Properties.Resources.zright;
					}
					if (x.Top > pictureBox1.Top)
					{

						x.Top -= zkecp;
						((PictureBox)x).Image = Properties.Resources.zup;
					}
					if (x.Top < pictureBox1.Top)
					{

						x.Top += zkecp;
						((PictureBox)x).Image = Properties.Resources.zdown;
					}
				}

				int ctr = 0;

				foreach (Control j in this.Controls) {
										
					if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie") {

						if (x.Bounds.IntersectsWith(j.Bounds) && ctr % 2 == 0) {

							nilai++;
							
							this.Controls.Remove(j);
							((PictureBox)j).Dispose();
							this.Controls.Remove(x);
							((PictureBox)x).Dispose();
							lzombies.Remove(((PictureBox)x));
							BuatZombie();
						}
						ctr++;
					}
				}
			}

		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				kiri = false;
			}
			else if (e.KeyCode == Keys.Right)
			{
				kanan = false;
			}
			else if (e.KeyCode == Keys.Up)
			{
				atas = false;
			}
			else if (e.KeyCode == Keys.Down)
			{
				bawah = false;
			}

			if (e.KeyCode == Keys.Space && ammo > 0 && kalah == false) {
				
				ammo--;
				if (ammo == 0) {
					ammo = 0;
				}
				tembak(arah);

				if (ammo < 1) {
					Ammo();
				}
			}

			if (e.KeyCode == Keys.Enter && kalah == true) {
				Restart();
			}

			if (e.Control ==true && e.KeyCode == Keys.A) {
					ammo += 5;
			}

			if (e.Control == true && e.KeyCode == Keys.H)
			{
				//progressBar1.TopLevelControl.
				pdarah = 200;
			}

			if (e.Control == true && e.KeyCode == Keys.P)
			{
				timer1.Stop();
				string message = "Play Game?";
				string title = "Pause";

				MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					timer1.Start();
				}
				else
				{
					this.Close();
			
				}
			}
			

		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (kalah == true) {
				return;
			}

			if (e.KeyCode == Keys.Left) {
				kiri = true;
				arah = "kiri";
				
				pictureBox1.Image = Properties.Resources.left;
				
			}
			if (e.KeyCode == Keys.Right) {
				kanan = true;
				arah = "kanan";
				
				pictureBox1.Image = Properties.Resources.right;
			}
			if (e.KeyCode == Keys.Up) {
				atas = true;
				arah = "atas";
				
				pictureBox1.Image = Properties.Resources.up;
			}
			if (e.KeyCode == Keys.Down) {
				bawah = true;
				arah = "bawah";
				
				pictureBox1.Image = Properties.Resources.down;
			}
		}

		private void scoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form3 data = new Form3();
			data.Show();
		}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Restart();
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			
		}

		
		private void Form1_MouseClick(object sender, MouseEventArgs e)
		{
			var me = (MouseEventArgs)e;
			this.pictureBox1.Location = new Point(me.X, me.Y);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
			form3.Show();
		}

		private void tembak(string tujuan) {
			Gun peluru = new Gun();
			peluru.tujuan = tujuan;
			
			peluru.tembakKiri = pictureBox1.Left + (pictureBox1.Width / 2);
			peluru.tembakAtas = pictureBox1.Top + (pictureBox1.Height / 2);
			peluru.buatPeluru(this);
		}

		private void BuatZombie() {
			PictureBox zombie = new PictureBox();
			zombie.Tag = "zombie";
			zombie.Image = Properties.Resources.down;
			zombie.Left = jml.Next(0, 800);
			zombie.Top = jml.Next(0, 600);
			zombie.SizeMode = PictureBoxSizeMode.AutoSize;
			lzombies.Add(zombie);
			this.Controls.Add(zombie);
			pictureBox1.BringToFront();
		}

		private void Ammo() {
			PictureBox ammo = new PictureBox();
			ammo.Tag = "ammo";
			ammo.Image = Properties.Resources.ammo_Image;
			ammo.Left = jml.Next(10, this.ClientSize.Width - ammo.Width);
			ammo.Top = jml.Next(60, this.ClientSize.Height - ammo.Height);
			
			this.Controls.Add(ammo);
			ammo.BringToFront();
			pictureBox1.BringToFront();
		}

		private void Restart() {
			pictureBox1.Image = Properties.Resources.up;
			foreach (PictureBox i in lzombies) {
				this.Controls.Remove(i);
			}

			lzombies.Clear();

			for (int i = 0; i < 3; i++)
			{
				BuatZombie();
			}

			atas = false;
			bawah = false;
			kiri = false;
			kanan = false;
			kalah = false;
			pdarah = 100;
			nilai = 0;
			ammo = 10;

			
			timer1.Start();
		}
	}
}
