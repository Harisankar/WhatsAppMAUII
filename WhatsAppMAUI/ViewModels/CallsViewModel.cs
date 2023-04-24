using System.Collections.ObjectModel;
using WhatsAppMAUI.Models;

namespace WhatsAppMAUI.ViewModels
{
    public class CallsViewModel : BaseViewModel
    {
        public CallsViewModel()
        {
            Title = "CALLS";
            CallHistory = new ObservableCollection<Call>(Services.CallService
                .GetCallHistory());
        }

        private ObservableCollection<Call> _callHistory;
        public ObservableCollection<Call> CallHistory
        {
            get { return _callHistory; }
            set { SetProperty(ref _callHistory, value); }
        }
    }
}
