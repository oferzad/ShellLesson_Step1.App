using Bumptech.Glide.Load;
using Microsoft.Extensions.Logging;
using ShellLesson.Services;
using ShellLesson.ViewModels;
using ShellLesson.Views;

namespace ShellLesson;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
            .RegisterDataServices()
            .RegisterPages()
            .RegisterViewModels();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

    public static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
    {
        //--------singleton Pages
        builder.Services.AddSingleton<StudentsView>();
        
        //--------Transient pages

        builder.Services.AddTransient<StudentDetailsView>();
      
        return builder;
    }

    public static MauiAppBuilder RegisterDataServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<StudentsService>();
        return builder;
    }
    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<StudentsViewModel>();
       
        //--------Transient ViewModels
        builder.Services.AddTransient<StudentDetailsViewModel>();
        
        return builder;
    }
}
