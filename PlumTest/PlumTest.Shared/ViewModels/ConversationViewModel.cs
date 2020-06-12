using PlumTest.Shared.Models;
using System.Collections.Generic;
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
            Conversations.Add(new PhoneConversationModel { Name = "Joe on the phone", CompanyName = "Joes Co.", CurrentActions = new List<IConversationAction> { new EndConversationAction(), new HoldConversationAction() } });
            Conversations.Add(new ChatConversationModel { Name = "Joe on chat", CompanyName = "Joes Co.", CurrentActions = new List<IConversationAction> { new EndConversationAction() } });
            Conversations.Add(new PhoneConversationModel { Name = "Pete on the phone", CompanyName = "Pete Ltd.", CurrentActions = new List<IConversationAction> { new EndConversationAction(), new HoldConversationAction() } });
            Conversations.Add(new ChatConversationModel { Name = "Pete on chat", CompanyName = "Pete Ltd.", CurrentActions = new List<IConversationAction> { new EndConversationAction() } });
            Conversations.Add(new PhoneConversationModel { Name = "Jane on the phone", CompanyName = "Jane Ltd.", CurrentActions = new List<IConversationAction> { new EndConversationAction(), new HoldConversationAction() } });
            Conversations.Add(new ChatConversationModel { Name = "Jane on chat", CompanyName = "Jane Ltd.", CurrentActions = new List<IConversationAction> { new EndConversationAction() } });
            Conversations.Add(new PhoneConversationModel { Name = "Alfie on the phone", CompanyName = "Alfie on Ltd.", CurrentActions = new List<IConversationAction> { new EndConversationAction(), new HoldConversationAction() } });
            Conversations.Add(new ChatConversationModel { Name = "Alfie on chat", CompanyName = "Alfie on Ltd.", CurrentActions = new List<IConversationAction> { new EndConversationAction() } });
            Conversations.Add(new PhoneConversationModel { Name = "Alice on the phone", CompanyName = "Alice Ltd.", CurrentActions = new List<IConversationAction> { new EndConversationAction(), new HoldConversationAction() } });
            Conversations.Add(new ChatConversationModel { Name = "Alice on chat", CompanyName = "Alice Ltd.", CurrentActions = new List<IConversationAction> { new EndConversationAction() } });
        }
    }
}
