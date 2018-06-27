using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using AtlantisApplication.Data;
using Xamarin.Forms;

namespace AtlantisApplication.Views
{
    class test_listsensorview : ContentPage
    {
        readonly DeviceAPI existingDevice;
        readonly TextCell nameDeviceTypeCell, typeDevicesCell, employeesCell, addressMacCell;
        readonly IList<DeviceAPI> devices;
        readonly DeviceAPIManager manager;

        public test_listsensorview(DeviceAPIManager manager, IList<DeviceAPI> devices, DeviceAPI existingDevice = null)
        {
            this.manager = manager;
            this.devices = devices;
            this.existingDevice = existingDevice;

            /*var tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot(existingDevice != null ? "go to" : "go new ?")
                {
                    new TableSection("Details")
                    {
                        new TextCell
                        {
                            Text = "id",
                            //Detail = (existingDevice != null) ? existingDevice.id : null,
                        },
                        (nameDeviceTypeCell = new TextCell
                        {
                            Text = "nameDeviceType",
                            Detail = (existingDevice != null) ? existingDevice.nameDeviceType : null,
                        }),
                        (typeDevicesCell = new TextCell
                        {
                            Text = "typeDevices",
                            Detail = (existingDevice != null) ? existingDevice.typeDevices : null,
                        }),
                        (employeesCell = new TextCell
                        {
                            Text = "employees",
                            Detail = (existingDevice != null) ? existingDevice.employees : null,
                        }),
                        (addressMacCell = new TextCell
                        {
                            Text = "addressMac",
                            Detail = (existingDevice != null) ? existingDevice.employees : null,
                        }),
                    },
                }
            };*/

            /* Button button = new Button()
             {
                 BackgroundColor = existingBook != null ? Color.Gray : Color.Green,
                 TextColor = Color.White,
                 Text = existingBook != null ? "Finished" : "Add Book",
                 BorderRadius = 0,
             };
             button.Clicked += OnDismiss;

             Content = new StackLayout
             {
                 Spacing = 0,
                 Children = { tableView, button },
             };*/
        }
    }
}