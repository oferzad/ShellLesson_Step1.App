using ShellLesson.Views;

namespace ShellLesson;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        RegisterRoutes();
	}

    void RegisterRoutes()
    {
        Routing.RegisterRoute("studentDetails", typeof(StudentDetailsView));

    }
}
