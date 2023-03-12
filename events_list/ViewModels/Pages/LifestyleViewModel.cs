using EventsCity.Models;
using EventsCity.ViewModels;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsCity.ViewModels.Pages
{
    public class LifestyleViewModel : ViewModelBase
    {
        private ObservableCollection<CityEvent> LifestyleCollection;
        public LifestyleViewModel(ObservableCollection<CityEvent> Events)
        {
            LifestyleCollection = new ObservableCollection<CityEvent>();
            var array = Events;
            for (int i = 0; i < Events.Count(); i++)
            {
                if (array[i].Category.Contains("Образ жизни") == true || array[i].Category.Contains("образ жизни") == true)
                {
                    if (array[i].Description.Length > 134)
                    {
                        array[i].Description.Remove(135);
                        array[i].Description += "...";
                    }
                    LifestyleCollection.Add(new CityEvent
                    {
                        Header = array[i].Header,
                        Description = array[i].Description,
                        Image = array[i].Image,
                        Date = array[i].Date,
                        Category = array[i].Category,
                        Price = array[i].Price
                    });
                }
            }
        }
        public ObservableCollection<CityEvent> Collection_of_lifestyle
        {
            get
            {
                return LifestyleCollection;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref LifestyleCollection, value);
            }
        }
    }
}
