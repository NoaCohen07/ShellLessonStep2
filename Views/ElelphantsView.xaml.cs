using ShellLessonStep2.ViewModels;

namespace ShellLessonStep2.Views;

public partial class ElephantsView : ContentPage
{
	public ElephantsView(ElephantsViewModel vm)
	{
		this.BindingContext = vm;
		InitializeComponent();
	}

}