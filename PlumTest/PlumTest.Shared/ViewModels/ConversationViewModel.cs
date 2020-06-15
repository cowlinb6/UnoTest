using PlumTest.Shared.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PlumTest.Shared.ViewModels
{
    public class ConversationViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<IConversationModel> Conversations { get; set; }

        private IConversationModel _currentConversation;
        public IConversationModel CurrentConversation 
        {
            get { return _currentConversation; }
            set
            {
                if (value == _currentConversation)
                {
                    return;
                }

                _currentConversation = value;
                OnPropertyChanged();
            }
        }

        public ConversationViewModel()
        {
            Conversations = new ObservableCollection<IConversationModel>();

            // Test data
            Conversations.Add(new PhoneConversationModel { Name = "Joe on the phone", CompanyName = "Joes Co.", CurrentActions = new List<IConversationAction> { new CallEndConversationAction(), new CallHoldConversationAction() } });
            Conversations.Add(new ChatConversationModel { Name = "Joe on chat", CompanyName = "Joes Co.", CurrentActions = new List<IConversationAction> { new ChatReplyConversationAction() } });
            Conversations.Add(new PhoneConversationModel { Name = "Pete on the phone", CompanyName = "Pete Ltd.", CurrentActions = new List<IConversationAction> { new CallEndConversationAction(), new CallHoldConversationAction() } });
            Conversations.Add(new ChatConversationModel { Name = "Pete on chat", CompanyName = "Pete Ltd.", CurrentActions = new List<IConversationAction> { new ChatReplyConversationAction() } });
            Conversations.Add(new PhoneConversationModel { Name = "Jane on the phone", CompanyName = "Jane Ltd.", CurrentActions = new List<IConversationAction> { new CallEndConversationAction(), new CallHoldConversationAction() } });
            Conversations.Add(new ChatConversationModel { Name = "Jane on chat", CompanyName = "Jane Ltd.", CurrentActions = new List<IConversationAction> { new ChatReplyConversationAction() } });
            Conversations.Add(new PhoneConversationModel { Name = "Alfie on the phone", CompanyName = "Alfie on Ltd.", CurrentActions = new List<IConversationAction> { new CallEndConversationAction(), new CallHoldConversationAction() } });
            Conversations.Add(new ChatConversationModel { Name = "Alfie on chat", CompanyName = "Alfie on Ltd.", CurrentActions = new List<IConversationAction> { new ChatReplyConversationAction() } });
            Conversations.Add(new PhoneConversationModel { Name = "Alice on the phone", CompanyName = "Alice Ltd.", CurrentActions = new List<IConversationAction> { new CallEndConversationAction(), new CallHoldConversationAction() } });
            Conversations.Add(new ChatConversationModel { Name = "Alice on chat", CompanyName = "Alice Ltd.", CurrentActions = new List<IConversationAction> { new ChatReplyConversationAction() } });
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
