using ShellLessonStep2.ViewModels;
namespace ShellLessonStep2.Views;

public partial class DogsView : ContentPage
{
    public DogsView(DogsViewModel vm)
    {
        this.BindingContext = vm;
        InitializeComponent();
    }
}