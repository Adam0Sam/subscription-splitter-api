using Microsoft.AspNetCore.Mvc;

namespace SubscriptionSplitter.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionsController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetSubscriptionById(int id)
        {
            var subscription = new { Id = id, Name = "Dummy Subscription", Cost = 10.99 };
            return Ok(subscription);
        }
    }
}
