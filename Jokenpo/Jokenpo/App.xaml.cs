﻿using Jokenpo.Views;

namespace Jokenpo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
