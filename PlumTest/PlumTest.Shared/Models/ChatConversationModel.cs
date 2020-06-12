using System;
using Windows.UI;

namespace PlumTest.Shared.Models
{
    public class ChatConversationModel : IConversationModel
    {
        public string Type => nameof(ChatConversationModel);
        public Color Color => Color.FromArgb(255, 255, 0, 0);

        public string Id => $"{Guid.NewGuid()}";
        public string Name { get; set; }
    }
}
