using WhatsAppMAUI.ViewModels;
using WhatsAppMAUI.Models;
namespace WhatsAppMAUI.Pages;

public partial class StatusPage : ContentPage
{
	public StatusPage()
	{
		InitializeComponent();
        BindingContext = viewModel = new StatusViewModel();
    }

    public StatusPage(StatusViewModel model) :this()
    {
        InitializeComponent();
        BindingContext = viewModel = model;
    }

    private StatusViewModel viewModel;
    
    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item != null)
        {
            var item = (Status)e.Item;
          //  await Navigation.PushModalAsync(new StatusDetailView(item));
        }
    }

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
       
        //await Navigation.PushModalAsync(new StatusDetailView(s));

    }
}