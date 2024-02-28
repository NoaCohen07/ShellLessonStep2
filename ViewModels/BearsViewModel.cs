using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShellLessonStep2.Models;
using System.Collections.ObjectModel;
using ShellLessonStep2.Services;


namespace ShellLessonStep2.ViewModels
{
    public class BearsViewModel:ViewModelBase
    {
        public BearsViewModel(AnimalService service)
        {
            IList<Animal> list = service.GetBears();
            bears = new ObservableCollection<Animal>(list);
            BearSelectedCommand = new Command(OnBearSelected);
        }
        private ObservableCollection<Animal> bears;
        public ObservableCollection<Animal> Bears
        {
            get
            {
                return this.bears;
            }
            set
            {
                this.bears = value;
                OnPropertyChanged();
            }
        }
        private Animal selectedAnimal;
        public Animal SelectedAnimal
        {
            get
            {
                return this.selectedAnimal;
            }
            set
            {
                this.selectedAnimal = value;
                OnPropertyChanged();
            }
        }

        public Command BearSelectedCommand { get; set; } 
        private void OnBearSelected()
        {
            Dictionary<string, object> data = new Dictionary<string, object>() 
            {
                {"selected", SelectedAnimal }
            };
            Shell.Current.GoToAsync("details", data);
        }
    }
}
