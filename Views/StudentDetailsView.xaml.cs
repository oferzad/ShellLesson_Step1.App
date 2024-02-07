using ShellLesson.ViewModels;

namespace ShellLesson.Views;

public partial class StudentDetailsView : ContentPage
{
	public StudentDetailsView(StudentDetailsViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}