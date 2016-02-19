using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.Devices.Geolocation;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MapsSample.Models;

namespace MapsSample.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Pushpin> _pushpins;
        public ObservableCollection<Pushpin> Pushpins
        {
            get { return _pushpins; }
            set { Set(ref _pushpins, value); }
        }

        private double _zoomlevel;
        public double ZoomLevel
        {
            get { return _zoomlevel; }
            set { Set(ref _zoomlevel, value); }
        }

        private Geopoint _center;
        public Geopoint Center
        {
            get { return _center; }
            set { Set(ref _center, value); }
        }

        private RelayCommand _showPushpins;
        public RelayCommand ShowPushpins
        {
            get
            {
                _showPushpins = _showPushpins ?? new RelayCommand(() =>
                {
                    Center = new Geopoint(new BasicGeoposition {Latitude = 45.4646, Longitude = 9.1882});
                    ZoomLevel = 15;
                    List<Pushpin> points = new List<Pushpin>
                    {
                        new Pushpin("Location 1", 45.4646, 9.1882),
                        new Pushpin("Location 2", 45.4615, 9.1915),
                        new Pushpin("Location 3", 45.4583, 9.1913),
                        new Pushpin("Location 4", 45.4620, 9.1836),
                        new Pushpin("Location 5", 45.4662, 9.2026)
                    };
                    Pushpins = new ObservableCollection<Pushpin>(points);
                });
                return _showPushpins;
            }
        }
    }
}
