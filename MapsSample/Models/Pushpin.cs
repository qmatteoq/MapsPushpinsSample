using System.Windows.Input;
using Windows.Devices.Geolocation;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MapsSample.Messages;

namespace MapsSample.Models
{
    public class Pushpin
    {
        public string Name { get; set; }

        public BasicGeoposition Point { get; set; }

        public Pushpin(string name, double latitude, double longitude)
        {
            this.Name = name;
            this.Point = new BasicGeoposition { Latitude = latitude, Longitude = longitude };
        }


        public ICommand SelectCommand => new RelayCommand(Select);

        public void Select()
        {
            Messenger.Default.Send(new MessageDialogMessage(Name));
        }
    }
}
