using System.Threading.Tasks;

namespace PlumTest.Shared.Models
{
    public class CallHoldConversationAction : IConversationAction
    {
        public async Task Run()
        {
            await Task.CompletedTask;
        }

        public string Name => "Call Hold";
    }
}
