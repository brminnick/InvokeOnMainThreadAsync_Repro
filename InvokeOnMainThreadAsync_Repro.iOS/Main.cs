﻿using UIKit;

namespace InvokeOnMainThreadAsync_Repro.iOS
{
    public class Application
    {
        static void Main(string[] args) => UIApplication.Main(args, null, nameof(AppDelegate));
    }
}
