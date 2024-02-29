namespace GuessTheGame
{
	partial class MainMenu
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
			sgBtn = new Button();
			mpBtn = new Button();
			title = new Label();
			SuspendLayout();
			// 
			// sgBtn
			// 
			sgBtn.Anchor = AnchorStyles.Bottom;
			sgBtn.AutoSize = true;
			sgBtn.BackColor = Color.RoyalBlue;
			sgBtn.FlatStyle = FlatStyle.Flat;
			sgBtn.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
			sgBtn.ForeColor = SystemColors.Window;
			sgBtn.Location = new Point(24, 65);
			sgBtn.Name = "sgBtn";
			sgBtn.Size = new Size(135, 36);
			sgBtn.TabIndex = 0;
			sgBtn.Text = "Singleplayer";
			sgBtn.UseVisualStyleBackColor = false;
			sgBtn.Click += sgBtn_Click;
			// 
			// mpBtn
			// 
			mpBtn.Anchor = AnchorStyles.Bottom;
			mpBtn.AutoSize = true;
			mpBtn.BackColor = Color.RoyalBlue;
			mpBtn.FlatStyle = FlatStyle.Flat;
			mpBtn.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
			mpBtn.ForeColor = SystemColors.Window;
			mpBtn.Location = new Point(175, 65);
			mpBtn.Name = "mpBtn";
			mpBtn.Size = new Size(135, 36);
			mpBtn.TabIndex = 1;
			mpBtn.Text = "Multiplayer";
			mpBtn.UseVisualStyleBackColor = false;
			mpBtn.Click += mpBtn_Click;
			// 
			// title
			// 
			title.Anchor = AnchorStyles.Top;
			title.AutoSize = true;
			title.Font = new Font("Yu Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			title.ForeColor = SystemColors.Window;
			title.Location = new Point(81, 20);
			title.Name = "title";
			title.Size = new Size(178, 25);
			title.TabIndex = 2;
			title.Text = "Guess The Game";
			// 
			// MainMenu
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MidnightBlue;
			ClientSize = new Size(333, 124);
			Controls.Add(title);
			Controls.Add(mpBtn);
			Controls.Add(sgBtn);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Name = "MainMenu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Guess The Game";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button sgBtn;
		private Button mpBtn;
		private Label title;
	}
}