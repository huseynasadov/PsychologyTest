using Psychology.Core.Repositories;
using System.Threading.Tasks;

namespace Psychology.Core
{
    public interface IUnitOfWork
    {
        IAdminRepository Admin { get; }
        IQuestionRepository Question { get; }
        Task<int> CommitAsync();
    }
}
