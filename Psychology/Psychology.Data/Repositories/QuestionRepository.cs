using Microsoft.EntityFrameworkCore;
using Psychology.Core.Models;
using Psychology.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psychology.Data.Repositories
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(PsychologyDbContext context) : base(context) { }

        private PsychologyDbContext _context
        {
            get { return Context as PsychologyDbContext; }
        }


        public async Task<IEnumerable<Question>> GetAllWithQuestionAsync()
        {
            return await _context.Questions.Where(filter => filter.Status)
                                 .ToListAsync();
        }

        public async Task<int> GetAllWithQuestionCountAsync()
        {
            return await _context.Questions.Where(filter => filter.Status).CountAsync();
        }

        public async Task<Question> GetAllWithQuestionById(long id)
        {
            return await _context.Questions
                                .FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<IEnumerable<Answer>> GetAllWithAnswersByQuestionIdAsync(long questionId)
        {
            return await _context.Answers.Where(filter => filter.QuestionId == questionId)
                                 .ToListAsync();
        }
    }
}
