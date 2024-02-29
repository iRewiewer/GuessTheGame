namespace GuessTheGame
{
	partial class App
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
			pictureBox1 = new PictureBox();
			correctBtn = new Button();
			wrongBtn = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(38, 39);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(350, 305);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// correctBtn
			// 
			correctBtn.BackColor = Color.MediumSeaGreen;
			correctBtn.FlatAppearance.BorderSize = 0;
			correctBtn.FlatStyle = FlatStyle.Flat;
			correctBtn.Font = new Font("A-OTF Shin Go Pro B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			correctBtn.ForeColor = SystemColors.Control;
			correctBtn.Location = new Point(38, 367);
			correctBtn.Name = "correctBtn";
			correctBtn.Size = new Size(141, 40);
			correctBtn.TabIndex = 1;
			correctBtn.Text = "Correct";
			correctBtn.UseVisualStyleBackColor = false;
			// 
			// wrongBtn
			// 
			wrongBtn.BackColor = Color.IndianRed;
			wrongBtn.FlatAppearance.BorderSize = 0;
			wrongBtn.FlatStyle = FlatStyle.Flat;
			wrongBtn.Font = new Font("A-OTF Shin Go Pro B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			wrongBtn.ForeColor = SystemColors.Control;
			wrongBtn.Location = new Point(247, 367);
			wrongBtn.Name = "wrongBtn";
			wrongBtn.Size = new Size(141, 40);
			wrongBtn.TabIndex = 2;
			wrongBtn.Text = "Wrong";
			wrongBtn.UseVisualStyleBackColor = false;
			// 
			// App
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MidnightBlue;
			ClientSize = new Size(426, 450);
			Controls.Add(wrongBtn);
			Controls.Add(correctBtn);
			Controls.Add(pictureBox1);
			Name = "App";
			Text = "App";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pictureBox1;
		private Button correctBtn;
		private Button wrongBtn;
	}
}