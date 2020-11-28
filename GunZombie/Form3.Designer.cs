namespace GunZombie
{
	partial class Form3
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.AI2 = new System.Windows.Forms.PictureBox();
			this.AI1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(167, 502);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(76, 60);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Controls.Add(this.pictureBox7);
			this.panel1.Controls.Add(this.pictureBox6);
			this.panel1.Controls.Add(this.pictureBox5);
			this.panel1.Controls.Add(this.AI2);
			this.panel1.Controls.Add(this.AI1);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(380, 424);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(165, 452);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "jarak:00";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = global::GunZombie.Properties.Resources.bronze;
			this.pictureBox7.Location = new System.Drawing.Point(61, 171);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(250, 100);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 6;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::GunZombie.Properties.Resources.carYellow;
			this.pictureBox6.Location = new System.Drawing.Point(167, 323);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(50, 101);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 5;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::GunZombie.Properties.Resources.explosion;
			this.pictureBox5.Location = new System.Drawing.Point(167, 242);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(64, 64);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 4;
			this.pictureBox5.TabStop = false;
			// 
			// AI2
			// 
			this.AI2.Image = global::GunZombie.Properties.Resources.carGreen;
			this.AI2.Location = new System.Drawing.Point(224, 64);
			this.AI2.Name = "AI2";
			this.AI2.Size = new System.Drawing.Size(50, 101);
			this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.AI2.TabIndex = 3;
			this.AI2.TabStop = false;
			// 
			// AI1
			// 
			this.AI1.Image = global::GunZombie.Properties.Resources.carGrey;
			this.AI1.Location = new System.Drawing.Point(61, 20);
			this.AI1.Name = "AI1";
			this.AI1.Size = new System.Drawing.Size(50, 101);
			this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.AI1.TabIndex = 2;
			this.AI1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::GunZombie.Properties.Resources.roadTrack;
			this.pictureBox2.Location = new System.Drawing.Point(-3, -222);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(385, 632);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::GunZombie.Properties.Resources.roadTrack;
			this.pictureBox1.Location = new System.Drawing.Point(-2, -638);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(385, 632);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(399, 657);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Name = "Form3";
			this.Text = "Form3";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.move);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stop);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox AI2;
		private System.Windows.Forms.PictureBox AI1;
		private System.Windows.Forms.Label label1;
	}
}