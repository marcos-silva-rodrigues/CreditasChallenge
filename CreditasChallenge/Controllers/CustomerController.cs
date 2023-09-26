using AutoMapper;
using CreditasChallenge.Domain;
using CreditasChallenge.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreditasChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly IMapper _mapper;

        public CustomerController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost("/loans")]
        public IActionResult GetLoansByCustomer([FromBody] CustomerDto dto)
        {
            var customer = _mapper.Map<Customer>(dto);
            var loans = LoanManager.GetTypesLoansAvailable(customer);

            return Ok(new ReadCustomerWithLoansDto(customer.Name, loans));
        }
    }
}
