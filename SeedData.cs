using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Prodotti.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
        {
            if (!context.Products.Any())
            {
                var json = System.IO.File.ReadAllText("products.json");
                var products = JsonConvert.DeserializeObject<List<Product>>(json);
                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}
