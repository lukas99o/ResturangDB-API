using ResturangDB_API.Models.DTOs;

namespace ResturangDB_API.Services.IServices
{
    public interface IBookingService
    {
        Task AddBookingAsync(BookingDTO booking);
        Task<IEnumerable<BookingDTO>> GetAllBookingsAsync();
        Task<BookingDTO> GetBookingByIdAsync(int bookingID);
        Task UpdateBookingAsync(BookingDTO booking);
        Task DeleteBookingAsync(int bookingID);
    }
}
