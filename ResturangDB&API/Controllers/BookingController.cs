using Microsoft.AspNetCore.Mvc;
using ResturangDB_API.Models.DTOs;
using ResturangDB_API.Services.IServices;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace ResturangDB_API.Controllers
{
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost]
        [Route("CreateBooking")]
        public async Task<ActionResult> CreateBooking(BookingDTO booking)
        {
            try
            {
                await _bookingService.AddBookingAsync(booking);
                return CreatedAtAction(nameof(GetSpecificBooking), new { id = booking.BookingID }, booking);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet]
        [Route("GetAllBookings")]
        public async Task<ActionResult<IEnumerable<BookingDTO>>> GetAllBookings()
        {
            var bookingList = await _bookingService.GetAllBookingsAsync();
            return Ok(bookingList);
        }

        [HttpGet]
        [Route("GetSpecificBooking")]
        public async Task<ActionResult> GetSpecificBooking(int bookingID)
        {
            var booking = await _bookingService.GetBookingByIdAsync(bookingID);
            return Ok(booking);
        }

        [HttpPut]
        [Route("UpdateBooking")]
        public async Task<ActionResult> UpdateSpecificBooking(BookingDTO booking)
        {
            await _bookingService.UpdateBookingAsync(booking);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteBooking")]
        public async Task<ActionResult> DeleteSpecificBooking(int bookingID)
        {
            await _bookingService.DeleteBookingAsync(bookingID);
            return Ok();
        }
    }
}
