using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prodotti.Data;
using System.Linq;
using System.Threading.Tasks;

public class ProductController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProductController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(string searchCategory, decimal? minPrice, decimal? maxPrice, int pageNumber = 1)
    {
        var query = _context.Products.Include(p => p.Category).AsQueryable();

        if (!string.IsNullOrEmpty(searchCategory))
            query = query.Where(p => p.Category.Name == searchCategory);

        if (minPrice.HasValue)
            query = query.Where(p => p.Price >= minPrice.Value);

        if (maxPrice.HasValue)
            query = query.Where(p => p.Price <= maxPrice.Value);

        int pageSize = 10;
        var products = await PaginatedList<Product>.CreateAsync(query.AsNoTracking(), pageNumber, pageSize);

        return View(products);
    }

    // Implementare CRUD (Create, Update, Delete)
}
