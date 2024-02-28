using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ShellLessonStep2.Services;
using ShellLessonStep2.Models;

namespace ShellLessonStep2.ViewModels
{
    public class DogsViewModel : ViewModelBase
    {
        public DogsViewModel(AnimalService service)
        {
            IList<Animal> list = service.GetDogs();
            dogs = new ObservableCollection<Animal>(list);
        }
        private ObservableCollection<Animal> dogs;
        public ObservableCollection<Animal> Dogs
        {
            get
            {
                return this.dogs;
            }
            set
            {
                this.dogs = value;
                OnPropertyChanged();
            }
        }
    }
}
