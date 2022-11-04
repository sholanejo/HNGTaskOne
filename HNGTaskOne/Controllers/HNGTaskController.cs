using HNGTaskOne.Models;
using Microsoft.AspNetCore.Mvc;

namespace HNGTaskOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HNGTaskController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var result = HNGService.GetService();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post(ArithmeticDTO arithmeticDTO)
        {
            var result = HNGService.PostService(arithmeticDTO);
            return Ok(result);
        }
    }
}
