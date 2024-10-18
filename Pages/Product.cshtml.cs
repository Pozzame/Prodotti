using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prodotti.Data;

 namespace Prodotti.Pages;
//namespace Prodotti.Data;

public class ProductModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public ProductModel(ApplicationDbContext context)
    {
        _context = context;
    }

    // Lista di prodotti da visualizzare nella vista
    public PaginatedList<Product> Products { get; set; }
    public IList<Category> Categories { get; set; }

    // Parametri per il filtro
    [BindProperty(SupportsGet = true)]
    public string? Category { get; set; }

    [BindProperty(SupportsGet = true)]
    public decimal? MinPrice { get; set; }

    [BindProperty(SupportsGet = true)]
    public decimal? MaxPrice { get; set; }

    // [BindProperty(SupportsGet = true)]
    // public int? CategoryId { get; set; }


    public async Task OnGetAsync(int pageNumber = 1)
    {
        var products = _context.Products.AsQueryable();
        // // Query base per i prodotti
        // var query = _context.Products.Include(p => p.Category).AsQueryable();

        // Filtraggio per categoria, se applicato
        if (Category != null)
        {
            products = products.Where(p => p.Category.Name == Category);
        }

        // Filtro per prezzo
        if (MinPrice.HasValue)
        {
            products = products.Where(p => p.Price >= MinPrice);
        }
        if (MaxPrice.HasValue)
        {
            products = products.Where(p => p.Price <= MaxPrice);
        }

        // // Filtro per categoria
        // if (CategoryId.HasValue && CategoryId.Value > 0)
        // {
        //     products = products.Where(p => p.CategoryId == CategoryId.Value);
        // }

        // Ottenere la lista delle categorie per il filtro
        // Categories = await _context.Categories.ToListAsync();

        // Numero di elementi per pagina
        int pageSize = 10;
        Products = await PaginatedList<Product>.CreateAsync(products, pageNumber, pageSize);
        Categories = await _context.Categories.ToListAsync();
    }
}
