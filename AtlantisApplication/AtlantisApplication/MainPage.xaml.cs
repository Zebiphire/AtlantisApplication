using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AtlantisApplication.Views;
using AtlantisApplication.Views.Login;
using Xamarin.Forms;

namespace AtlantisApplication
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    //GetButtonStyle();
        }

        private void SensorsButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListSensors());
        }

        private void CommandsButtonClicked(object sender, EventArgs e)
        {

        }

        private void UsersButtonClicked(object sender, EventArgs e)
        {

        }

        private void MetricsButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AllMetricsDisplayView());
        }

        private void CheckInternetButtonClicked(object sender, EventArgs e)
        {
            // bool internetActive = DependencyService.Get<IDeviceState>().isNetworkReachable();
            // this.DisplayAlert("Device Network", internetActive.ToString(), "OK");

            if (CrossConnectivity.Current.IsConnected)
            {
                this.DisplayAlert("Device Network", "Connected", "OK");
            }
            else
            {
                this.DisplayAlert("Device Network", "Not connected", "OK");
            }
        }

        private void AboutButtonClicked(object sender, EventArgs e)
        {

        }
     /*             public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(ICommand),
              typeof(ButtonWithSpinner));

          public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create(nameof(CommandParameter),
              typeof(object),
              typeof(ButtonWithSpinner));

          public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string),
              typeof(ButtonWithSpinner), null,
              propertyChanged: (bindable, oldVal, newVal) => ((ButtonWithSpinner)bindable).OnTextChange((string)newVal));

          public static readonly BindableProperty IsBusyProperty = BindableProperty.Create(nameof(IsBusy), typeof(bool),
              typeof(ButtonWithSpinner), false,
              propertyChanged: (bindable, oldVal, newVal) => ((ButtonWithSpinner)bindable).OnIsBusy((bool)newVal));

          public event EventHandler Clicked;

          public ICommand Command
          {
              get => (ICommand)GetValue(CommandProperty);
              set => SetValue(CommandProperty, value);
          }

          public object CommandParameter
          {
              get => GetValue(CommandParameterProperty);
              set => SetValue(CommandParameterProperty, value);
          }

          public string Text
          {
              get => (string)GetValue(TextProperty);
              set => SetValue(TextProperty, value);
          }

          public bool IsBusy
          {
              get => (bool)GetValue(IsBusyProperty);
              set => SetValue(IsBusyProperty, value);
          }

          private void OnTextChange(string value)
          {
              InnerButton.Text = value;
          }

          private void OnClicked(object sender, EventArgs e)
          {
              Clicked?.Invoke(this, EventArgs.Empty);

              if (Command == null || !Command.CanExecute(CommandParameter))
                  return;

              Command.Execute(CommandParameter);
          }

          private async void OnIsBusy(bool value)
          {
              if (value)
              {
                  InnerActivityView.IsVisible = true;
                  await InnerActivityView.FadeTo(1);
              }
              else
              {
                  await InnerActivityView.FadeTo(0);
                  InnerActivityView.IsVisible = false;
              }

              InnerActivityIndicator.IsRunning = value;
          }

          private void GetButtonStyle()
          {
              InnerBoxView.WidthRequest = InnerButton.Width;
              InnerBoxView.HeightRequest = InnerButton.Height;
              InnerBoxView.CornerRadius = InnerButton.CornerRadius;
              InnerBoxView.BackgroundColor = InnerButton.BackgroundColor;
              InnerBoxView.BorderThickness = (int)InnerButton.BorderWidth;
              InnerBoxView.BorderColor = InnerButton.BorderColor;
              InnerActivityIndicator.Color = InnerButton.TextColor;
          }*/
    }
}
