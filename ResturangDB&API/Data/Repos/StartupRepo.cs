﻿using Microsoft.EntityFrameworkCore;
using ResturangDB_API.Models;
using ResturangDB_API.Services;

namespace ResturangDB_API.Data.Repos
{
    public class StartupRepo
    {
        private readonly ResturangContext _context;

        public StartupRepo(ResturangContext context)
        {
            _context = context;
        }

        //public async Task IsTableAvailableAsync()
        //{
        //    var tables = await _context.Tables.ToListAsync();
        //    var bookings = await _context.Bookings.ToListAsync();

        //    foreach (var booking in bookings)
        //    {
        //        var bookedTable = tables.SingleOrDefault(t => t.TableID == booking.FK_TableID);

        //        if (bookedTable != null && DateTime.Now >= booking.BookingTimeEnd)
        //        {
        //            bookedTable.IsAvailable = true;
        //        }
        //    }

        //    await _context.SaveChangesAsync();
        //}

        public async Task UpdateTableAvailabilityAsync()
        {
            var endedBookings = await _context.Bookings
                .Where(b => DateTime.Now >= b.TimeEnd && b.Date == DateTime.Now.Date)
                .ToListAsync();

            var tableIdsToMarkAvailable = endedBookings
                .Select(b => b.FK_TableID)
                .Distinct()
                .ToList();

            var tablesToUpdate = await _context.Tables
                .Where(t => tableIdsToMarkAvailable.Contains(t.TableID))
                .ToListAsync();

            foreach (var table in tablesToUpdate)
            {
                table.IsAvailable = true;
            }

            await _context.SaveChangesAsync();
        }

    }
}
