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
    public class MonkeysViewModel : ViewModelBase
    {
        public MonkeysViewModel(AnimalService service)
        {
            IList<Animal> list = service.GetMonkeys();
            monkeys = new ObservableCollection<Animal>(list);

        }
        private ObservableCollection<Animal> monkeys;
        public ObservableCollection<Animal> Monkeys
        {
            get
            {
                return this.monkeys;
            }
            set
            {
                this.monkeys = value;
                OnPropertyChanged();
            }
        }
    }
}
