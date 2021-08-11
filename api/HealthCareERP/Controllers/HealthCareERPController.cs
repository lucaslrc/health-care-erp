using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HealthCareERP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCareERPController : ControllerBase
    {
        private readonly ILogger<HealthCareERPController> _logger;

        public HealthCareERPController(ILogger<HealthCareERPController> logger)
        {
            _logger = logger;
        }

        [HttpGet("test")]
        public string GetTest()
        {
            return "API is running";
        }
    }
}
