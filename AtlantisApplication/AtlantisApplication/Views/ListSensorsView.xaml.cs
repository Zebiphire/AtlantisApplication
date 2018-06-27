using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtlantisApplication.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtlantisApplication.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListSensorsView : ContentPage
	{

	    readonly DeviceAPIManager manager = new DeviceAPIManager();
	    readonly IList<DeviceAPI> DeviceAPIS= new ObservableCollection<DeviceAPI>();
	    bool alertShown = false;


        public ListSensorsView ()
		{
			InitializeComponent ();
		}


	    /*protected async override void OnAppearing()
	    {
	        base.OnAppearing();

	        if (Constants.RestUrl.Contains("developer.xamarin.com"))
	        {
	            if (!alertShown)
	            {
	                await DisplayAlert(
	                    "Hosted Back-End",
	                    "This app is running against Xamarin's read-only REST service. To create, edit, and delete data you must update the service endpoint to point to your own hosted REST service.",
	                    "OK");
	                alertShown = true;
	            }
	        }

	        listView.ItemsSource = await App.TodoManager.GetTasksAsync();
	    }*/


        async void OnRefresh(object sender, EventArgs e)
	    {
	        // Turn on network indicator
	        this.IsBusy = true;

	        try
	        {
	            var deviceCollection = await manager.GetAll();

	            foreach (DeviceAPI DeviceAPI in deviceCollection)
	            {
	                if (DeviceAPIS.All(b => b.id != DeviceAPI.id))
	                    DeviceAPIS.Add(DeviceAPI);
	            }
	        }
	        finally
	        {
	            this.IsBusy = false;
	        }
	    }
	    async void OnViewDevice(object sender, ItemTappedEventArgs e)
	    {
	        await Navigation.PushModalAsync(
            new SensorsPage(manager, DeviceAPIS, (DeviceAPI)e.Item));
	            //new test_listsensorview(manager, DeviceAPIS, (DeviceAPI)e.Item)); 

        }
    }
}