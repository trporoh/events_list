using EventsCity.Models;
using EventsCity.ViewModels.Pages;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace EventsCity.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<ViewModelBase> ViewModelBaseCollection;
        private ObservableCollection<CityEvent> CityEventCollection;

        public MainWindowViewModel()
        {
            CityEventCollection = new ObservableCollection<CityEvent>();
            XmlSerializer xml_serial = new XmlSerializer(typeof(ObservableCollection<CityEvent>));
            using (StreamReader reader = new StreamReader(@"..\..\..\Events.xml"))
            {
                CityEventCollection = xml_serial.Deserialize(reader) as ObservableCollection<CityEvent>;
            }
            ViewModelBaseCollection = new ObservableCollection<ViewModelBase>();
            ViewModelBaseCollection.Add(new KidsViewModel(CityEventCollection));
            ViewModelBaseCollection.Add(new SportViewModel(CityEventCollection));
            ViewModelBaseCollection.Add(new CultureViewModel(CityEventCollection));
            ViewModelBaseCollection.Add(new ExcursionViewModel(CityEventCollection));
            ViewModelBaseCollection.Add(new LifestyleViewModel(CityEventCollection));
            ViewModelBaseCollection.Add(new PartyViewModel(CityEventCollection));
            ViewModelBaseCollection.Add(new EducationViewModel(CityEventCollection));
            ViewModelBaseCollection.Add(new OnlineViewModel(CityEventCollection));
            ViewModelBaseCollection.Add(new ShowViewModel(CityEventCollection));
        }

        public object Kids
        {
            get => ViewModelBaseCollection[0];
        }

        public object Sport
        {
            get => ViewModelBaseCollection[1];
        }

        public object Culture
        {
            get => ViewModelBaseCollection[2];
        }

        public object Excursion
        {
            get => ViewModelBaseCollection[3];
        }

        public object Lifestyle
        {
            get => ViewModelBaseCollection[4];
        }

        public object Party
        {
            get => ViewModelBaseCollection[5];
        }

        public object Education
        {
            get => ViewModelBaseCollection[6];
        }

        public object Online
        {
            get => ViewModelBaseCollection[7];
        }

        public object Show
        {
            get => ViewModelBaseCollection[8];
        }

    }
}