using System;
using Windows.UI;
using Xamarin.Essentials;

namespace PlumTest.Shared.Models
{
    public class PhoneConversationModel : IConversationModel
    {
        public string Type => nameof(PhoneConversationModel);
        public Color Color => Color.FromArgb(255, 0, 255, 0);

        public string Id => $"{Guid.NewGuid()}";
        public string Name { get; set; }
    }
}
