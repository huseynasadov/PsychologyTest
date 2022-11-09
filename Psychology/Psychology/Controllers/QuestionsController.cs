using Microsoft.AspNetCore.Mvc;
using Psychology.Core.Services.Data;
using System.Threading.Tasks;

namespace Psychology.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        public QuestionsController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetQuestions() 
        {
            return Ok(await _questionService.GetAllQuestions());
        }
    }
}
