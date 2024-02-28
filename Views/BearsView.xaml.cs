using ShellLessonStep2.ViewModels;
namespace ShellLessonStep2.Views;

public partial class BearsView : ContentPage
{
    public BearsView(BearsViewModel vm)
    {
        this.BindingContext = vm;
        InitializeComponent();
    }
}