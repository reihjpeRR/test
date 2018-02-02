using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Test

{
    public partial class App : Application
    {

        //testa
        public App()
        {
            InitializeComponent();

            MainPage = new TestPage();
        }
        string droidKey = "37bb0b10-0eb0-4f2f-b90b-36519caa9fb2";
        string iOSKey = "cf1c4f63-381b-4854-ba24-9d433c74af84";
        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start($"$android={droidKey};ios={iOSKey}",
                 typeof(Analytics), typeof(Crashes));
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
