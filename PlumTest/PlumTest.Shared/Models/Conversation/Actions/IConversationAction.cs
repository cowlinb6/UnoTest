using System.Windows.Input;

namespace PlumTest.Shared.Models
{
    public interface IConversationAction
    {
        ICommand RunCommand { get; }

        string Name { get; }
    }
}
