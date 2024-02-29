namespace GuessTheGame
{
	partial class Singleplayer
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
			pictureBox = new PictureBox();
			correctBtn = new Button();
			wrongBtn = new Button();
			scoreLabel = new Label();
			skipBtn = new Button();
			hintsLabel = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
			SuspendLayout();
			// 
			// pictureBox
			// 
			pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox.Location = new Point(38, 74);
			pictureBox.Name = "pictureBox";
			pictureBox.Size = new Size(350, 272);
			pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox.TabIndex = 0;
			pictureBox.TabStop = false;
			pictureBox.Click += pictureBox_Click;
			// 
			// correctBtn
			// 
			correctBtn.Anchor = AnchorStyles.Bottom;
			correctBtn.BackColor = Color.MediumSeaGreen;
			correctBtn.FlatAppearance.BorderSize = 0;
			correctBtn.FlatStyle = FlatStyle.Flat;
			correctBtn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			correctBtn.ForeColor = SystemColors.Control;
			correctBtn.Location = new Point(12, 369);
			correctBtn.Name = "correctBtn";
			correctBtn.Size = new Size(141, 40);
			correctBtn.TabIndex = 1;
			correctBtn.Text = "Correct";
			correctBtn.UseVisualStyleBackColor = false;
			correctBtn.Click += correctBtn_Click;
			// 
			// wrongBtn
			// 
			wrongBtn.Anchor = AnchorStyles.Bottom;
			wrongBtn.BackColor = Color.IndianRed;
			wrongBtn.FlatAppearance.BorderSize = 0;
			wrongBtn.FlatStyle = FlatStyle.Flat;
			wrongBtn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			wrongBtn.ForeColor = SystemColors.Control;
			wrongBtn.Location = new Point(273, 369);
			wrongBtn.Name = "wrongBtn";
			wrongBtn.Size = new Size(141, 40);
			wrongBtn.TabIndex = 2;
			wrongBtn.Text = "Wrong";
			wrongBtn.UseVisualStyleBackColor = false;
			wrongBtn.Click += wrongBtn_Click;
			// 
			// scoreLabel
			// 
			scoreLabel.Anchor = AnchorStyles.Top;
			scoreLabel.AutoSize = true;
			scoreLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			scoreLabel.ForeColor = SystemColors.Window;
			scoreLabel.Location = new Point(61, 21);
			scoreLabel.Name = "scoreLabel";
			scoreLabel.Size = new Size(113, 33);
			scoreLabel.TabIndex = 3;
			scoreLabel.Text = "Score: 0";
			// 
			// skipBtn
			// 
			skipBtn.Anchor = AnchorStyles.Bottom;
			skipBtn.BackColor = Color.DimGray;
			skipBtn.FlatAppearance.BorderSize = 0;
			skipBtn.FlatStyle = FlatStyle.Flat;
			skipBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			skipBtn.ForeColor = SystemColors.Control;
			skipBtn.Location = new Point(175, 375);
			skipBtn.Name = "skipBtn";
			skipBtn.Size = new Size(80, 31);
			skipBtn.TabIndex = 4;
			skipBtn.Text = "Skip";
			skipBtn.UseVisualStyleBackColor = false;
			skipBtn.Click += skipBtn_Click;
			// 
			// hintsLabel
			// 
			hintsLabel.Anchor = AnchorStyles.Top;
			hintsLabel.AutoSize = true;
			hintsLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			hintsLabel.ForeColor = SystemColors.Window;
			hintsLabel.Location = new Point(260, 21);
			hintsLabel.Name = "hintsLabel";
			hintsLabel.Size = new Size(106, 33);
			hintsLabel.TabIndex = 5;
			hintsLabel.Text = "Hints: 0";
			// 
			// Singleplayer
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MidnightBlue;
			ClientSize = new Size(426, 421);
			Controls.Add(hintsLabel);
			Controls.Add(skipBtn);
			Controls.Add(scoreLabel);
			Controls.Add(wrongBtn);
			Controls.Add(correctBtn);
			Controls.Add(pictureBox);
			Name = "Singleplayer";
			Text = "Guess The Game";
			FormClosing += Singleplayer_FormClosing;
			Load += App_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox;
		private Button correctBtn;
		private Button wrongBtn;
		private Label scoreLabel;
		private Button skipBtn;
		private Label hintsLabel;
	}
}