using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VTrivia.Model;

namespace VTrivia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create(Quiz quiz)
        {
            quiz = { };
        }
    }
}
