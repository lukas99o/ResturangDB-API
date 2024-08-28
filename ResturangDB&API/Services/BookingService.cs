using ResturangDB_API.Data.Repos.IRepos;
using ResturangDB_API.Models.DTOs;
using ResturangDB_API.Models;
using ResturangDB_API.Services.IServices;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ResturangDB_API.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepo _bookingRepo;
        private readonly ITableRepo _tableRepo;


        public BookingService(IBookingRepo bookingRepo, ITableRepo tableRepo)
        {
            _bookingRepo = bookingRepo;
            _tableRepo = tableRepo;
        }

        public async Task AddBookingAsync(BookingDTO booking)
        {
            var newBooking = new Booking
            {
                FK_CustomerID = booking.FK_CustomerID,
                FK_TableID = booking.FK_TableID,
                AmountOfPeople = booking.AmountOfPeople,
                BookingDay = booking.BookingDay,
                BookingTime = booking.BookingTime,
                BookingTimeEnd = booking.BookingTimeEnd
            };

            await _bookingRepo.AddBookingAsync(newBooking);
        }

        public async Task<IEnumerable<BookingDTO>> GetAllBookingsAsync()
        {
            var bookingList = await _bookingRepo.GetAllBookingsAsync();

            return bookingList.Select(booking => new BookingDTO
            {
                BookingID = booking.BookingID,
                FK_CustomerID = booking.FK_CustomerID,
                FK_TableID = booking.FK_TableID,
                AmountOfPeople = booking.AmountOfPeople,
                BookingDay = booking.BookingDay,
                BookingTime = booking.BookingTime,
                BookingTimeEnd = booking.BookingTimeEnd
            }).ToList();
        }

        public async Task<BookingDTO> GetBookingByIdAsync(int bookingID)
        {
            var booking = await _bookingRepo.GetBookingByIDAsync(bookingID);

            if (booking == null)
            {
                return null;
            }

            return new BookingDTO
            {
                BookingID = booking.BookingID,
                FK_CustomerID = booking.FK_CustomerID,
                FK_TableID = booking.FK_TableID,
                AmountOfPeople = booking.AmountOfPeople,
                BookingDay = booking.BookingDay,
                BookingTime = booking.BookingTime
            };
        }

        public async Task UpdateBookingAsync(BookingDTO booking)
        {
            var updatedBooking = new Booking
            {
                BookingID = booking.BookingID,
                FK_CustomerID = booking.FK_CustomerID,
                FK_TableID = booking.FK_TableID,
                AmountOfPeople = booking.AmountOfPeople,
                BookingDay = booking.BookingDay,
                BookingTime = booking.BookingTime
            };

            await _bookingRepo.UpdateBookingAsync(updatedBooking);
        }

        public async Task DeleteBookingAsync(int bookingID)
        {
            await _bookingRepo.DeleteBookingAsync(bookingID);
        }
    }
}
