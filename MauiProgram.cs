﻿using Microsoft.Extensions.Logging;
using ShellLessonStep2.ViewModels;
using ShellLessonStep2.Views;
using ShellLessonStep2.Services;

namespace ShellLessonStep2;

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
        builder.Services.AddSingleton<CatsView>();
        builder.Services.AddSingleton<DogsView>();
        builder.Services.AddSingleton<BearsView>();
        builder.Services.AddSingleton<ElephantsView>();
        builder.Services.AddSingleton<MonkeysView>();

        builder.Services.AddTransient<AnimalDetailsView>();
        return builder;
    }

    public static MauiAppBuilder RegisterDataServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<AnimalService>();
        return builder;
    }
    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<CatsViewModel>();
        builder.Services.AddSingleton<DogsViewModel>();
        builder.Services.AddSingleton<BearsViewModel>();
        builder.Services.AddSingleton<ElephantsViewModel>();
        builder.Services.AddSingleton<MonkeysViewModel>();
        builder.Services.AddTransient<AnimalDetailViewModel>();

        return builder;
    }
}

