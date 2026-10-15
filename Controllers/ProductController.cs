using DigitalWarehouseAPI.Data;
using DigitalWarehouseAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigitalWarehouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/product
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_context.Products.ToList());
        }

        // POST: api/product
        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();

                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException?.Message ?? ex.Message);
            }
        }

        // PUT: api/product/1
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product updatedProduct)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound("Product not found");
            }

            product.ProductName = updatedProduct.ProductName;
            product.Category = updatedProduct.Category;
            product.ZoneId = updatedProduct.ZoneId;

            _context.SaveChanges();

            return Ok(product);
        }

        // DELETE: api/product/1
       [HttpDelete("{id}")]
public IActionResult DeleteProduct(int id)
{
    try
    {
        var product = _context.Products
            .FirstOrDefault(p => p.Id == id);

        if (product == null)
        {
            return NotFound("Product not found");
        }

        var inventoryRecords = _context.Inventories
            .Where(i => i.ProductId == id)
            .ToList();

        _context.Inventories.RemoveRange(inventoryRecords);

        _context.Products.Remove(product);

        _context.SaveChanges();

        return Ok("Product Deleted Successfully");
    }
    catch (Exception ex)
    {
        return BadRequest(ex.InnerException?.Message ?? ex.Message);
    }
}
    }
}