namespace GuessTheGame
{
	public partial class Multiplayer : Form
	{
		private Form parent;
		private int clickCount = 0;
		private int hintsLeft = 3;
		private bool shownHintsDialogue = false;
		private Dictionary<string, List<string>> games = new Dictionary<string, List<string>>();
		private IEnumerator<KeyValuePair<string, List<string>>> gameEnumerator;
		private IEnumerator<string> imageEnumerator;

		public Multiplayer(Form parent)
		{
			this.parent = parent;
			InitializeComponent();
		}

		private void App_Load(object sender, EventArgs e)
		{
			// bug with fonts so gotta load em thru code
			SetFonts();
			Reset();
		}

		private void nextBtn_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"The game was '{gameEnumerator.Current.Key}'.");
			UpdateHints();
			NextImage();
		}

		private void pictureBox_Click(object sender, EventArgs e)
		{
			clickCount += 1;

			if (clickCount > 2) // 3 clicks
			{
				clickCount = 0;
				GiveHint();
			}
		}

		private void Multiplayer_FormClosing(object sender, FormClosingEventArgs e)
		{
			parent.Show();
		}

		private void UpdateHints()
		{
			hintsLabel.Text = $"Hints left: {hintsLeft}";
		}

		private void NextImage()
		{
			shownHintsDialogue = false;

			if (gameEnumerator.MoveNext())
			{
				string currentGame = gameEnumerator.Current.Key;
				List<string> images = gameEnumerator.Current.Value;
				hintsLeft = images.Count - 1;

				if (images.Count > 0)
				{
					imageEnumerator = images.GetEnumerator();
					imageEnumerator.MoveNext();
					string imagePath = Path.Combine(Consts.ImagesFolderPath, currentGame, imageEnumerator.Current);
					pictureBox.ImageLocation = imagePath;
				}
				else
				{
					MessageBox.Show(Consts.NoImagesError);
				}
			}
			else
			{
				MessageBox.Show(Consts.GameOver);
				Reset();
			}

			UpdateHints();
		}

		private void GiveHint()
		{
			if (hintsLeft == 0)
			{
				if (!shownHintsDialogue)
				{
					MessageBox.Show(Consts.NoMoreHints);
					shownHintsDialogue = true;
				}
			}
			else
			{
				hintsLeft -= 1;
			}

			if (gameEnumerator != null)
			{
				string currentGame = gameEnumerator.Current.Key;
				List<string> images = gameEnumerator.Current.Value;

				if (images.Count > 0)
				{
					if (imageEnumerator == null || !imageEnumerator.MoveNext())
					{
						imageEnumerator = images.GetEnumerator();
						imageEnumerator.MoveNext();
					}

					string imagePath = Path.Combine(Consts.ImagesFolderPath, currentGame, imageEnumerator.Current);
					pictureBox.ImageLocation = imagePath;
				}
				else
				{
					MessageBox.Show("[Error] There are no images for this game. Check the images folder.");
				}
			}
			else
			{
				MessageBox.Show($"No more hints available.");
			}

			UpdateHints();
		}

		private void Reset()
		{
			ScanGames();

			if (games.Count == 0)
			{
				MessageBox.Show(Consts.EmptyImagesFolder);
				Application.Exit();
			}

			gameEnumerator = games.GetEnumerator();
			NextImage();
		}

		private void ScanGames()
		{
			if (!Directory.Exists(Consts.ImagesFolderPath))
			{
				Directory.CreateDirectory(Consts.ImagesFolderPath);
			}

			string[] subfolders = Directory.GetDirectories(Consts.ImagesFolderPath);

			foreach (string subfolder in subfolders)
			{
				string subfolderName = Path.GetFileName(subfolder);
				string[] files = Directory.GetFiles(subfolder);

				List<string> fileList = new List<string>();
				foreach (string file in files)
				{
					fileList.Add(Path.GetFileName(file));
				}

				games.Add(subfolderName, fileList);
			}
		}

		private void SetFonts()
		{
			hintsLabel.Font = new Font("ShinGoPro-Bold", 20, FontStyle.Bold);
			nextBtn.Font = new Font("ShinGoPro-Bold", 14, FontStyle.Bold);
		}
	}
}
