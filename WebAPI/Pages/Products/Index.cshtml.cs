using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebAPI.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly WebAPI.Models.WebAPIContext _context;

        public IndexModel(WebAPI.Models.WebAPIContext context)
        {
            _context = context;
        }

        public SelectList Models { get; private set; }
        public IList<Product> Product { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Brands { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ProductBrand { get; set; }
        public string ProductModel { get; set; }

        public async Task OnGetAsync()
        {
            var products = from p in _context.Product select p;

            if (!string.IsNullOrEmpty(SearchString))
            {
                products = products.Where(s => s.Brand.Contains(SearchString));
            }

            Product = await products.ToListAsync();
        }
    }
}
