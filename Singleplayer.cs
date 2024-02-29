namespace GuessTheGame
{
	public partial class Singleplayer : Form
	{
		private Form parent;
		private int score = 0;
		private int gamesGuessed = 0;
		private int totalGames = 0;
		private int clickCount = 0;
		private int hintsLeft = 3;
		private bool shownHintsDialogue = false;
		private Dictionary<string, List<string>> games = new Dictionary<string, List<string>>();
		private IEnumerator<KeyValuePair<string, List<string>>> gameEnumerator;
		private IEnumerator<string> imageEnumerator;

		public Singleplayer(Form parent)
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

		private void correctBtn_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Correct! The game was {gameEnumerator.Current.Key}.");
			score += hintsLeft + 1;
			gamesGuessed += 1;
			RemoveCurrentGame();
			NextImage();
		}

		private void wrongBtn_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Wrong! The game was {gameEnumerator.Current.Key}.");
			RemoveCurrentGame();
			NextImage();
		}

		private void pictureBox_Click(object sender, EventArgs e)
		{
			clickCount += 1;

			if (clickCount > 2)
			{
				clickCount = 0;
				GiveHint();
			}
		}

		private void skipBtn_Click(object sender, EventArgs e)
		{
			if (games.Count == 1)
			{
				MessageBox.Show(Consts.LastSkip);
				return;
			}
			else
			{
				score = (score - 1 < 0) ? 0 : score - 1;
			}

			KeyValuePair<string, List<string>> currentGame = gameEnumerator.Current;
			List<KeyValuePair<string, List<string>>> tempList = games.ToList();
			tempList.Remove(currentGame);
			tempList.Add(currentGame);

			games = tempList.ToDictionary(pair => pair.Key, pair => pair.Value);

			gameEnumerator = games.GetEnumerator();

			NextImage();
		}

		private void Singleplayer_FormClosing(object sender, FormClosingEventArgs e)
		{
			parent.Show();
		}

		private void UpdateUI()
		{
			hintsLabel.Text = $"Hints: {hintsLeft}";
			scoreLabel.Text = $"Score: {score}";
		}

		private void NextImage()
		{
			shownHintsDialogue = false;

			if (gameEnumerator.MoveNext())
			{
				string currentGame = gameEnumerator.Current.Key;
				List<string> images = gameEnumerator.Current.Value;
				hintsLeft = images.Count - 1;
				UpdateUI();

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
				UpdateUI();
				MessageBox.Show($"No more games! Final score: {score} points.\nCorrectly guessed: {gamesGuessed}/{totalGames} games.");
				Reset();
			}
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

			UpdateUI();

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
					MessageBox.Show(Consts.NoImagesError);
				}
			}
			else
			{
				MessageBox.Show(Consts.NoMoreHints);
			}
		}

		private void RemoveCurrentGame()
		{
			KeyValuePair<string, List<string>> currentGame = gameEnumerator.Current;
			List<KeyValuePair<string, List<string>>> tempList = games.ToList();
			tempList.Remove(currentGame);

			games = tempList.ToDictionary(pair => pair.Key, pair => pair.Value);

			gameEnumerator = games.GetEnumerator();
		}

		private void Reset()
		{
			score = 0;
			UpdateUI();
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

			totalGames = games.Keys.Count;
		}

		private void SetFonts()
		{
			scoreLabel.Font = new Font("ShinGoPro-Bold", 20, FontStyle.Bold);
			correctBtn.Font = new Font("ShinGoPro-Bold", 14, FontStyle.Bold);
			wrongBtn.Font = new Font("ShinGoPro-Bold", 14, FontStyle.Bold);
			skipBtn.Font = new Font("ShinGoPro-Bold", 10, FontStyle.Bold);
		}
	}
}
