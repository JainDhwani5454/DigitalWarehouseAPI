using DigitalWarehouseAPI.Data;

namespace DigitalWarehouseAPI.Services
{
    public class AssistantService
    {
        private readonly ApplicationDbContext _context;

        public AssistantService(ApplicationDbContext context)
        {
            _context = context;
        }

        public string GetAnswer(string question)
        {
            return $"Total products available are {_context.Products.Count()}";
        }
    }
}