using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtlantisApplication.Controller;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtlantisApplication.Views.Disabled
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class isDisabledDevice : ContentPage
	{
	    public int Id { get; }
        public string NameSensor { get; }
        public Boolean IsDisabled { get; }

        public isDisabledDevice (int id, Boolean isDisabled, string nameSensor)
		{
			InitializeComponent ();
		    Id = id;
            NameSensor = nameSensor;
		    IsDisabled = isDisabled;
            BindingContext = this;
		}

        private async Task isDisabledButton_onClickedAsync(object sender, EventArgs e)
        {
            string whatIsTheStateForDisable = IsDisabled.ToString();

            if (whatIsTheStateForDisable == "False")
            {
                disabled.Text = "True";
                string desactivate_activate = "disabled";

                await SendDisabledUpdate.SendIsDisabledUpdateAsync(Id, desactivate_activate);

            } 
            else if (whatIsTheStateForDisable == "True")
            {
                disabled.Text = "False";
                string desactivate_activate = "activate";
                await SendDisabledUpdate.SendIsDisabledUpdateAsync(Id, desactivate_activate);
            }
        }
    }
}