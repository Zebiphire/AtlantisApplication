using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtlantisApplication.Views.Login
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPageEliotView : ContentPage
	{

	    const string ServiceId = "Eliot";
	    const string Scope = "profile";

	    Account account;
	    AccountStore store;

        public LoginPageEliotView ()
		{

			InitializeComponent ();

		    var browser = new WebView();
		    browser.Source = "https://partners-login.eliotbylegrand.com/authorize?client_id=358ca400-fdf6-4357-8cca-27caa6699197&response_type=code&redirect_uri=https://login.microsoftonline.com/tfp/oauth2/nativeclient";
		    Content = browser;

		    string toBeSearched = "client_id=";
		    

            browser.Navigating += (object sender, WebNavigatingEventArgs e) =>
		    {
		        var url = e.Url;
		        Console.WriteLine(" Console.WriteLine(url); Console.WriteLine(url); Console.WriteLine(url); Console.WriteLine(url);");
                Console.WriteLine(url);


		        string tail = url.Substring(url.LastIndexOf('=') + 1);
                

                //string code = url.Substring(url.Last(toBeSearched) + toBeSearched.Length);
                //var test = url.Substring(url.LastIndexOf("client_id="));
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