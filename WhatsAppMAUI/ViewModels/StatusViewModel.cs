
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WhatsAppMAUI.Models;
using Status = WhatsAppMAUI.Models.Status;

namespace WhatsAppMAUI.ViewModels
{
    public class StatusViewModel : BaseViewModel
    {
        public Command TakePhotoCommand { get; private set; }

        public StatusViewModel()
        {
            Title = "STATUS";
            Me = Services.StatutsService.GetMyInfo();
            RecentUpdates = new ObservableCollection<Status>
                (Services.StatutsService.GetRecentUpdates());
            TakePhotoCommand = new Command(async () => await TakePhoto());
        }

        async Task TakePhoto()
        {
           
        }

        private Me _me;
        public Me Me
        {
            get { return _me; }
            set { SetProperty(ref _me, value); }
        }

        private ObservableCollection<Status> _recentUpdates;
        public ObservableCollection<Status> RecentUpdates
        {
            get { return _recentUpdates; }
            set { SetProperty(ref _recentUpdates, value); }
        }

    }
}
