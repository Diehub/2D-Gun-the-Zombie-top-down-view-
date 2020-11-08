using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;


namespace GunZombie
{
	class Gun
	{
		public string tujuan;
		public int tembakKiri;
		public int tembakAtas;

		private int kecp=20;
		private PictureBox peluru = new PictureBox();
		private Timer tickPeluru = new Timer();

		public void buatPeluru(Form form) {

			peluru.BackColor = Color.White;
			peluru.Size = new Size(5, 5);
			peluru.Tag = "bullet";
			peluru.Left = tembakKiri;
			peluru.Top = tembakAtas;
			peluru.BringToFront();

			form.Controls.Add(peluru);

			tickPeluru.Interval = kecp;
			tickPeluru.Tick += new EventHandler(PeluruTimerEvent);
			tickPeluru.Start();

		}


		private void PeluruTimerEvent(object sender, EventArgs e)
		{

			if (tujuan == "kiri") {
				peluru.Left -= kecp;
			}
			
			if (tujuan == "kanan")
			{
				peluru.Left += kecp;
			}

			if (tujuan == "atas")
			{
				peluru.Top -= kecp;
			}

			if (tujuan == "bawah")
			{
				peluru.Top += kecp;
			}

			if (peluru.Left < 10 || peluru.Left > 860 || peluru.Top < 10) {
				tickPeluru.Stop();
				tickPeluru.Dispose();
				peluru.Dispose();
				tickPeluru = null;
				peluru = null;

			}
		}
	}
}
