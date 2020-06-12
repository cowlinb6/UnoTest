using System;
using System.Collections.Generic;
using System.Text;

namespace PlumTest.Shared.Models
{
    public class ChatConversationModel : IConversationModel
    {
        public string Type => nameof(ChatConversationModel);

        public string Id { get; set; }
        public string Name { get; set; }
    }
}
