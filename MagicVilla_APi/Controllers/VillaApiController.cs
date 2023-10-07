using MagicVilla_APi.Data;
using MagicVilla_APi.Models;
using MagicVilla_APi.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_APi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VillaApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult< IEnumerable<VillaDto>> GetAll()
        { 
            return Ok(_context.villas.ToList());
        }


        [HttpGet("{id:int}", Name = "Get")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<VillaDto> Get(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var v = _context.villas.FirstOrDefault(v => v.Id == id);
            if (v == null) { return NotFound(); }

            return Ok(v);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<VillaDto> AddVila([FromBody] VillaDto v)
        {
            if (_context.villas.FirstOrDefault(u => u.OwnerName.ToLower() == v.OwnerName.ToLower()) != null)
            {
                ModelState.AddModelError("CustomeError", "Villa name already exists");
                return BadRequest(ModelState);
            }

            if (v == null)
            {
                return BadRequest(v);
            }
            if (v.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            Villa villa = new()
            {
                OwnerName = v.OwnerName,
                Description = v.Description,
                area = v.area,
                numOFrooms = v.numOFrooms,
                city = v.city,
                StreetName = v.StreetName,
                villaNum = v.villaNum,
                price = v.price,
                imageUrl = v.imageUrl
            };


            _context.villas.Add(villa);
            _context.SaveChanges();
            return CreatedAtRoute("Get", new { id = v.Id }, v);
        }

        [HttpDelete("{id:int}", Name = "Delete")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<VillaDto> DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var villa = _context.villas.FirstOrDefault(i => i.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            _context.villas.Remove(villa);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id:int}", Name = "Update")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<VillaDto> Update(int id, [FromBody] VillaDto v)
        {

            if (id != v.Id || v == null)
            {
                return BadRequest();
            }
            Villa villa = new()
            {
                OwnerName = v.OwnerName,
                Description = v.Description,
                area = v.area,
                numOFrooms = v.numOFrooms,
                city = v.city,
                StreetName = v.StreetName,
                villaNum = v.villaNum,
                price = v.price,
                imageUrl = v.imageUrl
            };
            _context.Update(villa);
            _context.SaveChanges();

            return NoContent();

        }
        [HttpPatch("{id:int}", Name = "UpdatePartial")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<VillaDto> UpdatePartial(int id, JsonPatchDocument<VillaDto> v)
        {

            if (id == null || v == null)
            { return BadRequest(); }
            var villa = _context.villas.AsNoTracking().FirstOrDefault(i => i.Id == id);
           VillaDto villaDto = new()
            {
                OwnerName = villa.OwnerName,
                Description = villa.Description,
                area = villa.area,
                numOFrooms = villa.numOFrooms,
                city = villa.city,
                StreetName = villa.StreetName,
                villaNum = villa.villaNum,
                price = villa.price,
                imageUrl = villa.imageUrl
            };
            if (villa == null)
            {
                return BadRequest();
            }

            v.ApplyTo(villaDto, ModelState);

            Villa model = new()
            {
                OwnerName = villaDto.OwnerName,
                Description = villaDto.Description,
                area = villaDto.area,
                numOFrooms = villaDto.numOFrooms,
                city = villaDto.city,
                StreetName = villaDto.StreetName,
                villaNum = villaDto.villaNum,
                price = villaDto.price,
                imageUrl = villaDto.imageUrl
            };
            _context.Update(model);
            _context.SaveChanges();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();


        }


    }
}
