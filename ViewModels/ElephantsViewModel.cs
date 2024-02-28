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
    public class ElephantsViewModel : ViewModelBase
    {
        public ElephantsViewModel(AnimalService service)
        {
            IList<Animal> list = service.GetElephants();
            elephants = new ObservableCollection<Animal>(list);

        }
        private ObservableCollection<Animal> elephants;
        public ObservableCollection<Animal> Elephants
        {
            get
            {
                return this.elephants;
            }
            set
            {
                this.elephants = value;
                OnPropertyChanged();
            }
        }
    }
}
