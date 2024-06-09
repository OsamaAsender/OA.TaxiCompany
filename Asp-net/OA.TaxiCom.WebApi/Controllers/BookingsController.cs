using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OA.TaxiCom.Dto.Bookings;
using OA.TaxiCom.EfCore;
using OA.TaxiCom.Entities;

namespace OA.TaxiCom.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        #region Data and Constructor
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public BookingsController(ApplicationDbContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        #endregion

        #region Actions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingDto>>> GetBookings()
        {
           var bookings =  await _context.Bookings.ToListAsync();

            var bookingDtos = _mapper.Map<List<BookingDto>>(bookings);

            return bookingDtos;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<BookingDetailsDto>> GetBooking(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);

            if (booking == null)
            {
                return NotFound();
            }

            var bookingDetailDto = _mapper.Map<BookingDetailsDto>(booking);

            return bookingDetailDto;
        }

       
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, Booking booking)
        {
            if (id != booking.Id)
            {
                return BadRequest();
            }

            _context.Entry(booking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

       
        [HttpPost]
        public async Task<ActionResult> PostBooking(CreateUpdateBookingDto CreateUpdateBookingDto)
        {
            var booking = _mapper.Map<Booking>(CreateUpdateBookingDto);

            _context.Bookings.Add(booking);

            await _context.SaveChangesAsync();

            return Ok();
        }
     

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }

            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        #endregion

        #region private methods
        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.Id == id);
        }
        #endregion
    }
}
