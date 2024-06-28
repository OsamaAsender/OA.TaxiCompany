using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OA.TaxiCom.Dto.Cars;
using OA.TaxiCom.EfCore;
using OA.TaxiCom.Entities;

namespace OA.TaxiCom.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        #region Data and Const
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CarsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        #endregion

        #region Actions

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarDto>>> GetCars()
        {
            var cars = await _context.Cars.ToListAsync();

            var carsDto = _mapper.Map<List<CarDto>>(cars);

            return (carsDto);
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<CarDetailsDto>> GetCar(int id)
        {
            var car = await _context
                                   .Cars
                                   .Include(c => c.Driver)
                                   .Include(c => c.Bookings)
                                   .Where( c => c.Id == id)
                                   .SingleOrDefaultAsync();

            if (car == null)
            {
                return NotFound();
            }

            var carDetailsDto = _mapper.Map<CarDetailsDto>(car);

            return carDetailsDto;
        }

        // PUT: api/Cars/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754


        [HttpPut("{id}")]
        public async Task<IActionResult> PutCar(int id, Car car)
        {
            if (id != car.Id)
            {
                return BadRequest();
            }

            _context.Entry(car).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(id))
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
        public async Task<ActionResult<Car>> PostCar(CreateUpdateCarDto createUpdateCarDto)
        {
            var car = _mapper.Map<Car>(createUpdateCarDto);
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

            return Ok();
        }

    
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }

            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        #endregion

        #region Private Methods
        private bool CarExists(int id)
        {
            return _context.Cars.Any(e => e.Id == id);
        }
        #endregion
    }
}
