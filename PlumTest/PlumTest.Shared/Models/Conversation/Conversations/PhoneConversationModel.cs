using System;
using System.Collections.Generic;
using Windows.UI;

namespace PlumTest.Shared.Models
{
    public class PhoneConversationModel : IConversationModel
    {
        public string Type => nameof(PhoneConversationModel);
        public Color Color => Color.FromArgb(255, 0, 255, 0);

        public string Id => $"{Guid.NewGuid()}";
        public string Name { get; set; }
        public string CompanyName { get; set; }

        public IEnumerable<IConversationAction> CurrentActions { get; set; }
    }
}
