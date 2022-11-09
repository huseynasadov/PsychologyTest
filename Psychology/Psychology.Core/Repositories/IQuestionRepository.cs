using Psychology.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Psychology.Core.Repositories
{
    public interface IQuestionRepository : IRepository<Question>
    {
        Task<IEnumerable<Question>> GetAllWithQuestionAsync();
        Task<int> GetAllWithQuestionCountAsync();
        Task<Question> GetAllWithQuestionById(long id);
        Task<IEnumerable<Answer>> GetAllWithAnswersByQuestionIdAsync(long questionId);
    }
}
