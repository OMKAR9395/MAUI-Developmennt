﻿namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var navPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Colors.Blue,
                BarTextColor = Colors.White
            };

            return new Window(navPage);
        } 
    }
}