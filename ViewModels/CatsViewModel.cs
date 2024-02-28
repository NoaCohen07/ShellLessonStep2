using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShellLessonStep2.Models;
using ShellLessonStep2.Services;


namespace ShellLessonStep2.ViewModels
{
    public class CatsViewModel:ViewModelBase
    {
        public CatsViewModel(AnimalService service)
        {
            IList<Animal> list = service.GetCats();
            cats = new ObservableCollection<Animal>(list);
         
        }
        private ObservableCollection<Animal> cats;
        public ObservableCollection<Animal> Cats
        {
            get
            {
                return this.cats;
            }
            set
            {
                this.cats = value;
                OnPropertyChanged();
            }
        }
      
    }
}
