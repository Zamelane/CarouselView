using CarouselView.models;

namespace CarouselView;

public partial class InfoPage : ContentPage
{
	public InfoPage(Journalist journalist)
	{
		InitializeComponent();
		BindingContext = journalist;
	}
}