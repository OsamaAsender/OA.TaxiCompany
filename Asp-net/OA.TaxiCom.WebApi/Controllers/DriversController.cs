using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OA.TaxiCom.Dto.Drivers;
using OA.TaxiCom.EfCore;
using OA.TaxiCom.Entities;

namespace OA.TaxiCom.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        #region Data and Const
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public DriversController(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        #endregion

        #region Actions
        // GET: api/Drivers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DriverDto>>> GetDrivers()
        {
            var driver = await _context.Drivers.ToListAsync();

            var driverDto = _mapper.Map<List<DriverDto>>(driver);

            return driverDto;
        }

       
        [HttpGet("{id}")]
        public async Task<ActionResult<DriverDetailsDto>> GetDriver(int id)
        {
            var driver = await _context.Drivers.FindAsync(id);

            if (driver == null)
            {
                return NotFound();
            }

            var driverDetailsDto = _mapper.Map<DriverDetailsDto>(driver);

            return driverDetailsDto;
        }

      
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDriver(int id, Driver driver)
        {
            if (id != driver.Id)
            {
                return BadRequest();
            }

            _context.Entry(driver).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DriverExists(id))
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
        public async Task<ActionResult<Driver>> PostDriver(CreateUpdateDriverDto createUpdateDriverDto)
        {
            var driver = _mapper.Map<Driver>(createUpdateDriverDto);

            _context.Drivers.Add(driver);

            await _context.SaveChangesAsync();

            return Ok();
        }

        // DELETE: api/Drivers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDriver(int id)
        {
            var driver = await _context.Drivers.FindAsync(id);
            if (driver == null)
            {
                return NotFound();
            }

            _context.Drivers.Remove(driver);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        #endregion

        #region Private Functions
        private bool DriverExists(int id)
        {
            return _context.Drivers.Any(e => e.Id == id);
        }
        #endregion
    }
}
