using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private readonly MyDBContext _context;

        public BeerController(MyDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Beer> Get()
        {
            return _context.Beers.Where(n=> n.Name == "Honey")
                .ToList();
        }

    }
}
