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
    public class EducationViewModel : ViewModelBase
    {
        private ObservableCollection<CityEvent> EducationCollection;
        public EducationViewModel(ObservableCollection<CityEvent> Events)
        {
            EducationCollection = new ObservableCollection<CityEvent>();
            var array = Events;
            for (int i = 0; i < Events.Count(); i++)
            {
                if (array[i].Category.Contains("Образование") == true || array[i].Category.Contains("образование") == true)
                {
                    if (array[i].Description.Length > 134)
                    {
                        array[i].Description.Remove(135);
                        array[i].Description += "...";
                    }
                    EducationCollection.Add(new CityEvent
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
        public ObservableCollection<CityEvent> Collection_of_education
        {
            get
            {
                return EducationCollection;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref EducationCollection, value);
            }
        }
    }
}
