using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
using Contact = WhatsAppMAUI.Models.Contact;
using WhatsAppMAUI.ViewModels;

namespace WhatsAppMAUI.Pages;

public partial class ChatsPage : ContentPage
{
    public ChatsViewModel viewModel;
    public ChatsPage()
	{
		InitializeComponent();
        BindingContext = viewModel = new ChatsViewModel();
    }

    


    private async void Button_Clicked(object sender, EventArgs e)
    {
       // this.Navigation.PushAsync(new Camerapage());
        await DisplayAlert("Chat Button", "Select contact and ...", "OK");
    }

    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        await DisplayAlert("Item", "Item tapped", "OK");
    }
  
    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        Image img = sender as Image;
        Contact contact = img.BindingContext as Contact;
        
        var popup = new Popups.ProfilePopup(contact);

        this.ShowPopup(popup);
    }
}