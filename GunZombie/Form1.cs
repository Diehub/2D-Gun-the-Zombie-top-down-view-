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

		bool kanan, kiri, atas, bawah, kalah;
		string arah = "up";
		int pdarah = 100;
		int kecp = 3;
		int zkecp = 1;
		int ammo = 10;
		int nilai;
		Random jml = new Random();

		List<PictureBox> lzombies = new List<PictureBox>();

		public Form1()
		{
			InitializeComponent();
			Restart();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Click on the link below to continue learning how to build a desktop app using WinForms!
			System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

		}
		
		private void gamePlay(object sender, EventArgs e)
		{
			if (pdarah > 1)
			{
				progressBar1.Value = pdarah;
			}

			else {
				kalah = true;
				pictureBox1.Image = Properties.Resources.dead;
				timer1.Stop();
			}

			label1.Text = "Ammo:" + ammo;
			label2.Text = "Kill:" + nilai;

			if (kiri == true && pictureBox1.Left > 0) {
				pictureBox1.Left -= kecp;
			}
			if (kanan == true && pictureBox1.Left + pictureBox1.Width < this.ClientSize.Width) {
				pictureBox1.Left += kecp;
			}
			if (atas == true && pictureBox1.Top > 50)
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
			if (e.KeyCode == Keys.Space) {
				tembak(arah);
				ammo--;

				if (ammo < 1) {
					Ammo();
				}
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
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
			zombie.Image = Properties.Resources.zdown;
			zombie.Left = jml.Next(0, 800);
			zombie.Top = jml.Next(0, 500);
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

			pdarah = 100;
			nilai = 0;
			ammo = 10;

			timer1.Start();
		}
	}
}
