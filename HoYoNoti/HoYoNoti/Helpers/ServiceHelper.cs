namespace HoYoNoti.Helpers;

public static class ServiceHelper
{
    public static IServiceProvider Current =>
#if WINDOWS
            MauiWinUIApplication.Current.Services;
#elif ANDROID
            MauiApplication.Current.Services;
#elif IOS || MACCATALYST
            MauiUIApplicationDelegate.Current.Services;
#else
            null;
#endif

    public static TService GetService<TService>() => Current.GetService<TService>();
}
