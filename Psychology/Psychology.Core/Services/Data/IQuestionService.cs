using Psychology.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Psychology.Core.Services.Data
{
    public interface IQuestionService
    {
        Task<IEnumerable<Question>> GetAllQuestions();
        Task<IEnumerable<Question>> GetAllQuestions(int skip,int page,string order,string search);
        Task<int> GetAllQuestionsCount();
        Task<Question> GetQuestionById(long id);
        Task<IEnumerable<Answer>> GetAnwersByQuestionId(long questionId);
    }
}
