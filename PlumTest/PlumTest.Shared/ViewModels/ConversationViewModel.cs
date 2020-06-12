using PlumTest.Shared.Models;
using System.Collections.ObjectModel;

namespace PlumTest.Shared.ViewModels
{
    public class ConversationViewModel
    {
        public ObservableCollection<IConversationModel> Conversations { get; set; }

        public ConversationViewModel()
        {
            Conversations = new ObservableCollection<IConversationModel>();

            // Test data
            Conversations.Add(new PhoneConversationModel { Name = "Joe on the phone" });
            Conversations.Add(new ChatConversationModel { Name = "Joe on chat" });
        }
    }
}
