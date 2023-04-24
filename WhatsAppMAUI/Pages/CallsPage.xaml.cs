using System.Collections.ObjectModel;
using WhatsAppMAUI.ViewModels;

namespace WhatsAppMAUI.Pages;

public partial class CallsPage : ContentPage
{
    private CallsViewModel viewModel;
    public CallsPage()
	{
		InitializeComponent();
        BindingContext = viewModel = new CallsViewModel();
    }

	private void btnCalls_Clicked(object sender, EventArgs e)
	{

	}

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {

    }
}