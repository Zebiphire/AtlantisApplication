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

            var browser = new WebView();
            browser.Source = "https://partners-login.eliotbylegrand.com/authorize?client_id=358ca400-fdf6-4357-8cca-27caa6699197&response_type=code&redirect_uri=https://login.microsoftonline.com/tfp/oauth2/nativeclient";
            Content = browser;
            //Thread.Sleep(20000);
            //UrlWebViewSource test = new UrlWebViewSource();

            browser.Navigating += (object sender, WebNavigatingEventArgs e) =>
            {
                var url = e.Url;
                Console.WriteLine(url);
            };

            string t = browser.Source.ToString();

            //string t = test.Url;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine(t);
            
           
        }
    }
}