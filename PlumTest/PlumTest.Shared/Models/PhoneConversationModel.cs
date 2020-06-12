using System;
using System.Collections.Generic;
using System.Text;

namespace PlumTest.Shared.Models
{
    public class PhoneConversationModel : IConversationModel
    {
        public string Type => nameof(PhoneConversationModel);
        public string Id => $"{Guid.NewGuid()}";

        public string Name { get; set; }
    }
}
