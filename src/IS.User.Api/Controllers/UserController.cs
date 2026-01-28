using IS.User.Api.Model;
using Microsoft.AspNetCore.Mvc;
using IS.API.Common.Model;

namespace IS.User.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Get()
        {
            UserViewModel model = new UserViewModel();

            return Ok(new ApiResponse<UserViewModel> { Data = model, Status = ApiResponseStatus.Success });
        }
    }
}
