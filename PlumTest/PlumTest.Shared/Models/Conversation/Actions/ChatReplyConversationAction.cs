using PlumTest.Shared.Commands;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PlumTest.Shared.Models
{
    public class ChatReplyConversationAction : IConversationAction
    {
        private ICommand _runCommand;

        public ICommand RunCommand
        {
            get
            {
                if (_runCommand == null)
                {
                    _runCommand = new AsyncCommand(Run, CanSave);
                }
                return _runCommand;
            }
        }

        public string Name => "Chat Reply";

        private bool CanSave()
        {
            return true;
        }

        private async Task Run()
        {
            await Task.CompletedTask;
        }
    }
}
