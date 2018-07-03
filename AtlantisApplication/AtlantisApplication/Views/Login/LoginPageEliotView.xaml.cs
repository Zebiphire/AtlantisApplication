using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using AtlantisApplication.Models;
using AtlantisApplication.ViewModels;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtlantisApplication.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPageEliotView :ContentPage
    {

        const string ServiceId = "Eliot";
        const string Scope = "profile";
        private string code2 = null;

        Account account;
        AccountStore store;

        List<Token> ListToken = new List<Token>();

        public LoginPageEliotView()
        {

            InitializeComponent();

            var browser = new WebView();
            browser.Source = "https://partners-login.eliotbylegrand.com/authorize?client_id=358ca400-fdf6-4357-8cca-27caa6699197&response_type=code&redirect_uri=https://login.microsoftonline.com/tfp/oauth2/nativeclient";
            Content = browser;
            

              browser.Navigating += async (object sender, WebNavigatingEventArgs e) =>
              {

                  var url = e.Url;
                  Uri uri = new Uri(url.ToString());
                  code2 = HttpUtility.ParseQueryString(uri.Query).Get("code");
                  if (code2 != null)
                  {
                      ListToken = await GetTokenAccessEliot.GetTokenAsync(code2);
                  }
              };




            //string t = browser.Source.ToString();

            //string t = test.Url;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            //Console.WriteLine(test);

        }
    }
}