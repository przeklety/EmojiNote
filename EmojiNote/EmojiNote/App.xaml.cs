using EmojiNote.Services;
using EmojiNote.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmojiNote
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
