using Microsoft.AspNetCore.Mvc;
using ResturangDB_API.Models;
using ResturangDB_API.Models.DTOs;
using ResturangDB_API.Services;
using ResturangDB_API.Services.IServices;

namespace ResturangDB_API.Controllers
{
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        [Route("CreateCustomer")]
        public async Task<ActionResult> CreateCustomer(CustomerDTO customer)
        {
            await _customerService.AddCustomerAsync(customer);
            return Created();
        }

        [HttpGet]
        [Route("GetAllCustomers")]
        public async Task<ActionResult<IEnumerable<CustomerDTO>>> GetAllCustomers()
        {
            var customerList = await _customerService.GetAllCustomersAsync();
            return Ok(customerList);
        } 

        [HttpGet]
        [Route("GetSpecificCustomer")]
        public async Task<ActionResult<CustomerDTO>> GetSpecificCustomer(int customerID)
        {
            var customer = await _customerService.GetCustomerByIdAsync(customerID);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        [HttpPut]
        [Route("UpdateCustomer")]
        public async Task<ActionResult> UpdateSpecificCustomer(CustomerDTO customer)
        {
            await _customerService.UpdateCustomerAsync(customer);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteCustomer")]
        public async Task<ActionResult> DeleteSpecificCustomer(int customerID)
        {
            await _customerService.DeleteCustomerAsync(customerID);
            return Ok();
        }
    }
}
