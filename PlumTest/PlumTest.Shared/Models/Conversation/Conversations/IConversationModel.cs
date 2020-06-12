﻿using System.Collections.Generic;
using Windows.UI;

namespace PlumTest.Shared.Models
{
    public interface IConversationModel
    {
        string Type { get; }
        string Id { get; }
        Color Color { get; }

        string Name { get; set; }
        string CompanyName { get; set; }

        IEnumerable<IConversationAction> CurrentActions { get; set; }
    }
}
