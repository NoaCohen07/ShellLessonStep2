using ShellLessonStep2.ViewModels;
namespace ShellLessonStep2.Views;

public partial class AnimalDetailsView : ContentPage
{
	public AnimalDetailsView(AnimalDetailViewModel vm)
	{
		this.BindingContext=vm;
		InitializeComponent();
	}
}