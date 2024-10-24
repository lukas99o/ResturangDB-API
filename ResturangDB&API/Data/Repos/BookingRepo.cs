﻿using Microsoft.EntityFrameworkCore;
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

            if (tableToBeBooked == null)
            {
                throw new Exception($"This table doe's not exist");
            }
            else if (tableToBeBooked.TableSeats < booking.AmountOfPeople)
            {
                throw new Exception("Your company is to large for this table you need a table with more seats.");
            }
            else if (!tableToBeBooked.IsAvailable)
            {
                throw new Exception("Try another table this one is booked!");
            }
            else if (booking.Time < DateTime.Now || booking.TimeEnd <= booking.Time || booking.TimeEnd <= DateTime.Now.AddMinutes(30))
            {
                throw new Exception("Please input a valid booking time.");
            }
            else
            {
                await _context.Bookings.AddAsync(booking);
                await _context.SaveChangesAsync();
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
            var bookedTable = await _context.Tables.SingleOrDefaultAsync(t => t.TableID == booking.FK_TableID);

            if (bookedTable == null)
            {
                throw new Exception($"This table doe's not exist");
            }
            else if (bookedTable.TableSeats < booking.AmountOfPeople)
            {
                throw new Exception("Your company is to large for this table you need a table with more seats.");
            }
            else if (booking.Time < DateTime.Now || booking.TimeEnd <= booking.Time || booking.TimeEnd <= DateTime.Now.AddMinutes(30))
            {
                throw new Exception("Please input a valid booking time.");
            }
            else
            {
                _context.Bookings.Update(booking);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteBookingAsync(Booking booking)
        {
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
        }
    }
}
