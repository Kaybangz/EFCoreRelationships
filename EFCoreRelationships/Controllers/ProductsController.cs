using EFCoreRelationships.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreRelationships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductsController(ApplicationDbContext applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get(int categoryId)
        {
            var products = await _applicationDbContext.Products
                .Where(p => p.CategoryId == categoryId)
                .Include(p => p.Size)
                .Include(p => p.Colors)
                .ToListAsync();


            return products;
        }



    }
}
