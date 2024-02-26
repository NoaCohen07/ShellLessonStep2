using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShellLessonStep2.Models;
using ShellLessonStep2.Services;
using Xamarin.Google.Crypto.Tink.Mac;

namespace ShellLessonStep2.ViewModels
{
    public class CatsViewModel:ViewModelBase
    {
        public CatsViewModel()
        {
            animals = new ObservableCollection<Animal>();
        }
        private ObservableCollection<Animal> animals;
        public ObservableCollection<Animal> Animals
        {
            get
            {
                return this.animals;
            }
            set
            {
                this.animals = value;
                OnPropertyChanged();
            }
        }
      
    }
}
