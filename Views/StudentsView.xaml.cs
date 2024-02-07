using ShellLesson.ViewModels;

namespace ShellLesson.Views;

public partial class StudentsView : ContentPage
{
	public StudentsView(StudentsViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}