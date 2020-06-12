using System.Threading.Tasks;

namespace PlumTest.Shared.Models
{
    public interface IConversationAction
    {
        Task Run();

        string Name { get; }
    }
}
