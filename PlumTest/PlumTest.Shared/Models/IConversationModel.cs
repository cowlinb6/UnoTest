using System;
using System.Collections.Generic;
using System.Text;

namespace PlumTest.Shared.Models
{
    public interface IConversationModel
    {
        string Type { get; }
        string Id { get; }

        string Name { get; set; }
    }
}
