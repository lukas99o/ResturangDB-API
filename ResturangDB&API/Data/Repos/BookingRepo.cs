using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ResturangDB_API.Data.Repos.IRepos;
using ResturangDB_API.Models;

namespace ResturangDB_API.Data.Repos
{
    public class BookingRepo : IBookingRepo
    {
        private readonly ResturangContext _context;

        public BookingRepo(ResturangContext context)
        {
            _context = context;
        }

        public async Task AddBookingAsync(Booking booking)
        {
            var tableToBeBooked = await _context.Tables.SingleOrDefaultAsync(t => t.TableID == booking.FK_TableID);

            if (tableToBeBooked != null && tableToBeBooked.IsAvailable)
            {
                tableToBeBooked.IsAvailable = false;
                await _context.Bookings.AddAsync(booking);
                await _context.SaveChangesAsync();
                Console.WriteLine("Table Available: " + tableToBeBooked.IsAvailable);
                Console.WriteLine("TableID: " + tableToBeBooked.TableID);
            } 
            else
            {
                throw new Exception("Try another table this one is booked!");
            }
        }

        public async Task<IEnumerable<Booking>> GetAllBookingsAsync()
        {
            var bookingList = await _context.Bookings.ToListAsync();
            return bookingList;
        }

        public async Task<Booking> GetBookingByIDAsync(int bookingID)
        {
            var booking = await _context.Bookings.FindAsync(bookingID);
            return booking;
        }

        public async Task UpdateBookingAsync(Booking booking)
        {
            _context.Bookings.Update(booking);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBookingAsync(int bookingID)
        {
            var booking = await _context.Bookings.FindAsync(bookingID);

            if (booking != null)
            {
                _context.Bookings.Remove(booking);
            }

            await _context.SaveChangesAsync();
        }
    }
}
