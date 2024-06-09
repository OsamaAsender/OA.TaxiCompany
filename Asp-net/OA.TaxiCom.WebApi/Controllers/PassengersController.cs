using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OA.TaxiCom.Dto.Passengers;
using OA.TaxiCom.EfCore;
using OA.TaxiCom.Entities;

namespace OA.TaxiCom.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        #region Data and Const
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PassengersController(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        #endregion

        #region Actions
       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PassengerDto>>> GetPassengers()
        {
            var passenger = await _context.Passengers.ToListAsync();

            var passengerdto = _mapper.Map<List<PassengerDto>>(passenger);

            return (passengerdto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PassengerDetailsDto>> GetPassenger(int id)
        {
            var passenger = await _context.Passengers.FindAsync(id);

            if (passenger == null)
            {
                return NotFound();
            }

            var passengerDetailDto = _mapper.Map<PassengerDetailsDto>(passenger);

            return passengerDetailDto;
        }

       
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPassenger(int id, Passenger passenger)
        {
            if (id != passenger.Id)
            {
                return BadRequest();
            }

            _context.Entry(passenger).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PassengerExists(id))
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
        public async Task<ActionResult<Passenger>> PostPassenger(CreateUpdatePassengerDto Cpassenger)
        {
            var createpassenger = _mapper.Map<Passenger>(Cpassenger);

            _context.Passengers.Add(createpassenger);

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePassenger(int id)
        {
            var passenger = await _context.Passengers.FindAsync(id);
            if (passenger == null)
            {
                return NotFound();
            }

            _context.Passengers.Remove(passenger);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        #endregion

        #region Private Functions
        private bool PassengerExists(int id)
        {
            return _context.Passengers.Any(e => e.Id == id);
        }
        #endregion
    }
}
