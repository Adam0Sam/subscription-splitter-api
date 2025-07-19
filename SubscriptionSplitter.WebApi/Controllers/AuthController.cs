using MediatR;
using Microsoft.AspNetCore.Mvc;
using SubscriptionSplitter.Application.Features.Auth.Commands;
using SubscriptionSplitter.Application.Features.Auth.DTO;

namespace SubscriptionSplitter.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterUserRequest request)
        {
            var response = await _mediator.Send(new RegisterUserCommand(request));
            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUserRequest request)
        {
            var response = await _mediator.Send(new LoginUserCommand(request));
            return Ok(response);
        }
    }
}
