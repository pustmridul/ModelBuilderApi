using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ModelBuilderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestModelsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public TestModelsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAgeRange()
        {
            try
            {
                var result = await _context.AgeRanges.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
    }
}
