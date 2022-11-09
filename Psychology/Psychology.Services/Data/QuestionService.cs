using CryptoHelper;
using Psychology.Core;
using Psychology.Core.Models;
using Psychology.Core.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;

namespace Psychology.Services.Data
{
    public class QuestionService : IQuestionService
    {
        private readonly IUnitOfWork _unitOfWork;
        public QuestionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Question>> GetAllQuestions()
        {
            return await _unitOfWork.Question.GetAllWithQuestionAsync();
        }

        public async Task<IEnumerable<Question>> GetAllQuestions(int skip, int page, string order, string search)
        {
            var questions = await _unitOfWork.Question.GetAllFilterAsync(filter => filter.Status && filter.Description.Contains(search), o => o.OrderBy(string.IsNullOrEmpty(order) ? "Id desc" : order), null, skip, page);
            return questions;
        }

        public async Task<int> GetAllQuestionsCount()
        {
            return await _unitOfWork.Question.GetAllWithQuestionCountAsync();
        }

        public async Task<Question> GetQuestionById(long id)
        {
            return await _unitOfWork.Question.GetAllWithQuestionById(id);
        }

        public async Task<IEnumerable<Answer>> GetAnwersByQuestionId(long questionId)
        {
            return await _unitOfWork.Question.GetAllWithAnswersByQuestionIdAsync(questionId);
        }

    }
}
