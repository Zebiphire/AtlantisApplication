using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AtlantisApplication.Controller;
using Newtonsoft.Json.Linq;
using Xamarin.Auth;
using Xamarin.Auth.Presenters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtlantisApplication.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPageView : ContentPage
    {
        const string ServiceId = "Eliot";
        const string Scope = "profile";

        Account account;
        AccountStore store;

        public LoginPageView()
        {
            InitializeComponent();

        }
        void OnButtonClicked(object sender, EventArgs args)
        {
            Button_Login.IsVisible = false;
            // Show overlay with ProgressBar. 
            overlay.IsVisible = true;
            TimeSpan duration = TimeSpan.FromSeconds(3);
            DateTime startTime = DateTime.Now;
            // Start timer. 
            Device.StartTimer(TimeSpan.FromSeconds(0.1), () =>
            {
                double progress = (DateTime.Now - startTime).TotalMilliseconds / duration.TotalMilliseconds;
                progressBar.Progress = progress;
                bool continueTimer = progress < 1;

                if (!continueTimer)
                {
                    // Hide overlay. 
                    overlay.IsVisible = false;
                }
                return continueTimer;
            });
        }

        async Task Button_Login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
            //await Navigation.PushModalAsync(new Overlay());
        }
    }
}