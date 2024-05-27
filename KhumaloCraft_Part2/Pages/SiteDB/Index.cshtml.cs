using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KhumaloCraft_Part2.Data;
using KhumaloCraft_Part2.Models;

namespace KhumaloCraft_Part2.Pages.SiteDB
{
    public class IndexModel : PageModel
    {
        private readonly KhumaloCraft_Part2.Data.ProductsDBContext _context;

        public IndexModel(KhumaloCraft_Part2.Data.ProductsDBContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Product != null)
            {
                Product = await _context.Product.ToListAsync();
            }
        }
    }
}
