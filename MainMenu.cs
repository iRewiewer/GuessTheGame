namespace GuessTheGame
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		private void sgBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Singleplayer(this).Show();
		}

		private void mpBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Multiplayer(this).Show();
		}
	}
}
