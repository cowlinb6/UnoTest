using System.Threading.Tasks;

namespace PlumTest.Shared.Models
{
    public class ChatReplyConversationAction : IConversationAction
    {
        public async Task Run()
        {
            await Task.CompletedTask;
        }

        public string Name => "Chat Reply";
    }
}
