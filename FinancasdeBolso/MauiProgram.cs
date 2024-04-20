using CommunityToolkit.Maui;
using FinancasdeBolso.Repositories;
using FinancasdeBolso.View;
using LiteDB;
using Microsoft.Extensions.Logging;

namespace FinancasdeBolso
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .RegisterDatabaseRepositories()
                .RegisterViews();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        public static MauiAppBuilder RegisterDatabaseRepositories(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<LiteDatabase>(
                options =>
                {
                    return new LiteDatabase($"Filename={AppSettings.DatabasePath};Connection=Shared");
                });
            mauiAppBuilder.Services.AddTransient<ITransicaoRepositorio, TransicaoRepositorio>();
            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<CadastroAdd>();
            mauiAppBuilder.Services.AddTransient<TelaEdicao>();
            mauiAppBuilder.Services.AddTransient<TelaInicial>();
            return mauiAppBuilder;
        }
    }
}
