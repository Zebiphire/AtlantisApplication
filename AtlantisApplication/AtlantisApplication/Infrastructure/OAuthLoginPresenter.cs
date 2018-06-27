using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Auth;

namespace AtlantisApplication.Infrastructure
{
    public class OAuthLoginPresenter
    {
        public event EventHandler<AuthenticatorCompletedEventArgs> Completed;

        public static Action<Authenticator> PlatformLogin;

        public void Login(Authenticator authenticator)
        {
            authenticator.Completed += OnAuthCompleted;

            PlatformLogin(authenticator);
        }

        void OnAuthCompleted(object sender, global::Xamarin.Auth.AuthenticatorCompletedEventArgs e)
        {
            if (Completed != null)
                Completed(sender, e);

            ((Authenticator)sender).Completed -= OnAuthCompleted;
        }
    }
}
