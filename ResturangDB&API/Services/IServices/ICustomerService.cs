using ResturangDB_API.Models;
using ResturangDB_API.Models.DTOs;

namespace ResturangDB_API.Services.IServices
{
    public interface ICustomerService
    {
        Task AddCustomerAsync(CustomerDTO customer);
        Task<IEnumerable<CustomerDTO>> GetAllCustomersAsync();
        Task<CustomerDTO> GetCustomerByIdAsync(int customerID);
        Task UpdateCustomerAsync(CustomerDTO customer);
        Task DeleteCustomerAsync(int customerID);
    }
}
