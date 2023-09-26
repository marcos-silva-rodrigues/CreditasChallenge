using CreditasChallenge.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreditasChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        [HttpPost("/loans")]
        public IActionResult GetLoansByCustomer([FromBody] CustomerDto dto)
        {
            return Ok();
        }
    }
}
