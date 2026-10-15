using DigitalWarehouseAPI.Models;
using DigitalWarehouseAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DigitalWarehouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssistantController : ControllerBase
    {
        private readonly AssistantService _assistantService;

        public AssistantController(AssistantService assistantService)
        {
            _assistantService = assistantService;
        }

        [HttpPost]
        public IActionResult AskAssistant([FromBody] AssistantRequest request)
        {
            try
            {
                var answer = _assistantService.GetAnswer(request.Question);

                return Ok(new
                {
                    Answer = answer
                });
            }
            catch (Exception ex)
            {
                return BadRequest(
                    ex.InnerException?.Message ?? ex.Message
                );
            }
        }
    }
}