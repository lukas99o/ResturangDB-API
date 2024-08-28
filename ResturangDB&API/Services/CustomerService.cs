using ResturangDB_API.Data.Repos;
using ResturangDB_API.Data.Repos.IRepos;
using ResturangDB_API.Models;
using ResturangDB_API.Models.DTOs;
using ResturangDB_API.Services.IServices;

namespace ResturangDB_API.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;

        public CustomerService(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;   
        }

        public async Task AddCustomerAsync(CustomerDTO customer)
        {
            var newCustomer = new Customer
            {
                Name = customer.Name,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };

            await _customerRepo.AddCustomerAsync(newCustomer);
        }

        public async Task<IEnumerable<CustomerDTO>> GetAllCustomersAsync()
        {
            var customerList = await _customerRepo.GetAllCustomersAsync();
            return customerList.Select(customer => new CustomerDTO
            {
                CustomerID = customer.CustomerID,
                Name = customer.Name,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            }).ToList();
        }

        public async Task<CustomerDTO> GetCustomerByIdAsync(int customerID)
        {
            var customer = await _customerRepo.GetCustomerByIDAsync(customerID);
            
            if (customer == null)
            {
                return null;
            }

            return new CustomerDTO
            {
                CustomerID = customer.CustomerID,
                Name = customer.Name,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };
        }

        public async Task UpdateCustomerAsync(CustomerDTO customer)
        {
            var updatedCustomer = new Customer
            {
                CustomerID = customer.CustomerID,
                Name = customer.Name,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };

            await _customerRepo.UpdateCustomerAsync(updatedCustomer);
        }

        public async Task DeleteCustomerAsync(int customerID)
        {
            await _customerRepo.DeleteCustomerAsync(customerID);
        }
    }
}
