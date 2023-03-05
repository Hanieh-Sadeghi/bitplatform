﻿using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Bit.BlazorUI.Demo.Web
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiAppBuilder().Build();
    }
}