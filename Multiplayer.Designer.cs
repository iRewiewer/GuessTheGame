namespace GuessTheGame
{
	partial class Multiplayer
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
			nextBtn = new Button();
			hintsLabel = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
			SuspendLayout();
			// 
			// pictureBox
			// 
			pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox.Location = new Point(32, 84);
			pictureBox.Name = "pictureBox";
			pictureBox.Size = new Size(364, 245);
			pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox.TabIndex = 0;
			pictureBox.TabStop = false;
			pictureBox.Click += pictureBox_Click;
			// 
			// nextBtn
			// 
			nextBtn.Anchor = AnchorStyles.Bottom;
			nextBtn.AutoSize = true;
			nextBtn.BackColor = Color.MediumSeaGreen;
			nextBtn.FlatAppearance.BorderSize = 0;
			nextBtn.FlatStyle = FlatStyle.Flat;
			nextBtn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			nextBtn.ForeColor = SystemColors.Control;
			nextBtn.Location = new Point(66, 348);
			nextBtn.Name = "nextBtn";
			nextBtn.Size = new Size(297, 52);
			nextBtn.TabIndex = 1;
			nextBtn.Text = "Next";
			nextBtn.UseVisualStyleBackColor = false;
			nextBtn.Click += nextBtn_Click;
			// 
			// hintsLabel
			// 
			hintsLabel.Anchor = AnchorStyles.Top;
			hintsLabel.AutoSize = true;
			hintsLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			hintsLabel.ForeColor = SystemColors.Window;
			hintsLabel.Location = new Point(140, 26);
			hintsLabel.Name = "hintsLabel";
			hintsLabel.Size = new Size(159, 37);
			hintsLabel.TabIndex = 2;
			hintsLabel.Text = "Hints left: 0";
			// 
			// Multiplayer
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MidnightBlue;
			ClientSize = new Size(426, 421);
			Controls.Add(hintsLabel);
			Controls.Add(nextBtn);
			Controls.Add(pictureBox);
			Name = "Multiplayer";
			Text = "Guess The Game";
			FormClosing += Multiplayer_FormClosing;
			Load += App_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox;
		private Button nextBtn;
		private Label hintsLabel;
	}
}