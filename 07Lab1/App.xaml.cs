namespace _07Lab1;

public partial class App : Application
{
	public static StudentRepository StudentRepo { get; private set; }
	public App(StudentRepository repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

		StudentRepo = repo;
	}
}
