using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace practica3CAR
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {

                }
                }
            };
            var tabs = new TabbedPage();
            tabs.Children.Add(new controles { Title = "Controles1" });
            tabs.Children.Add(new controles2 { Title = "Controles2" });
            tabs.Children.Add(new Page1 { Title = "Page1" });
            MainPage = tabs;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
