using CommunityToolkit.Maui.Views;
using WhatsAppMAUI;
using Contact = WhatsAppMAUI.Models.Contact;


namespace WhatsAppMAUI.Popups
{
       public partial class ProfilePopup : Popup
    {
        public ProfilePopup()
        {
            InitializeComponent();
        }
        public ProfilePopup(Contact Model) : this() {
            this.BindingContext = Model;
        }
    }
}