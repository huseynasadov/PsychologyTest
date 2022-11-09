using Microsoft.AspNetCore.Mvc;
using Psychology.Core.Services.Data;
using System.Threading.Tasks;

namespace Psychology.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        public AnswersController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet("{questionId}")]
        public async Task<IActionResult> GetAnswers(long questionId) 
        {
            return Ok(await _questionService.GetAnwersByQuestionId(questionId));
        }
    }
}
