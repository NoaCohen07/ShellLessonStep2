using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShellLessonStep2.Models;

namespace ShellLessonStep2.ViewModels
{
    [QueryProperty(nameof(SelectedAnimal), "selected")]
    public class AnimalDetailViewModel : ViewModelBase
    {
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
    }
}
