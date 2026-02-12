using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductGallery.Models;
using ProductGallery.Services;

namespace ProductGallery.Pages;

public class IndexModel : PageModel
{
    private readonly ProductService _productService;

    public IndexModel(ProductService productService)
    {
        _productService = productService;
    }

    public List<Product> Products { get; set; } = new();

    [BindProperty(SupportsGet = true)]
    public string? SearchTerm { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? SortOrder { get; set; }

    public void OnGet()
    {
        var products = _productService.GetProducts();

        if (!string.IsNullOrEmpty(SearchTerm))
        {
            products = products.Where(p => p.Name.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        switch (SortOrder)
        {
            case "price_asc":
                products = products.OrderBy(p => p.Price).ToList();
                break;
            case "price_desc":
                products = products.OrderByDescending(p => p.Price).ToList();
                break;
            default:
                break;
        }

        Products = products;
    }
}
