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
    public class DetailsModel : PageModel
    {
        private readonly KhumaloCraft_Part2.Data.ProductsDBContext _context;

        public DetailsModel(KhumaloCraft_Part2.Data.ProductsDBContext context)
        {
            _context = context;
        }

      public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }
            else 
            {
                Product = product;
            }
            return Page();
        }
    }
}
