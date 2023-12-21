namespace _07Lab1;
using _07Lab1.Models;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnNewButtonClicked(object sender, EventArgs e)
    {
        statusMessage.Text = "";

        App.StudentRepo.AddNewStudent(newStudent.Text);
        statusMessage.Text = App.StudentRepo.StatusMessage;
    }

    private void OnGetButtonClicked(object sender, EventArgs e)
    {
        statusMessage.Text = "";
        List<Student> section = App.StudentRepo.GetSection();
        sectionList.ItemsSource = section;
    }

    private void OnDeleteAllButtonClicked(object sender, EventArgs e)
    {
        statusMessage.Text = "";
        App.StudentRepo.DeleteStudents();
        statusMessage.Text = App.StudentRepo.StatusMessage;
    }
}

