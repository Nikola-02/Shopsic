using Microsoft.AspNetCore.Mvc;
using Shopsic.API.DTO;
using Shopsic.API.DTO.Categories;
using Shopsic.DataAccess;
using Shopsic.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shopsic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ShopsicContext _context;
        public CategoriesController(ShopsicContext shopsicContext)
        {
            _context = shopsicContext;
        }

        // GET: api/<CategoriesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateCategoryDTO dto)
        {
            try
            {
                Category categoryToAdd = new Category()
                {
                    Name = dto.Name,
                    Products = dto.Products
                };

                _context.Categories.Add(categoryToAdd);

                _context.SaveChanges();

                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
