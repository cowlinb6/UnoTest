using System.Threading.Tasks;

namespace PlumTest.Shared.Models
{
    public class CallEndConversationAction : IConversationAction
    {
        public async Task Run()
        {
            await Task.CompletedTask;
        }

        public string Name => "Call End";
    }
}
