using System.Threading.Tasks;

namespace PlumTest.Shared.Models
{
    public class EndConversationAction : IConversationAction
    {
        public async Task Run()
        {
            await Task.CompletedTask;
        }

        public string Name => "End";
    }
}
