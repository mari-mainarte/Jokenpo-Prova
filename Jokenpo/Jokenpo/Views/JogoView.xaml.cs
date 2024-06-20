using Jokenpo.ViewModel;

namespace Jokenpo.Views;

public partial class JogoView : ContentPage
{
	public JogoView()
	{
		InitializeComponent();
		BindingContext = new JogoViewModel();
	}
}