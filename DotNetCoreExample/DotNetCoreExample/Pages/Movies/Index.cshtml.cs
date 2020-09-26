using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DotNetCoreExample.Data;
using DotNetCoreExample.Models;

namespace DotNetCoreExample.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly DotNetCoreExample.Data.DotNetCoreExampleContext _context;

        public IndexModel(DotNetCoreExample.Data.DotNetCoreExampleContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
