using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProjectGameWebsite.Models;

namespace FinalProjectGameWebsite.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly FinalProjectGameWebsite.Models.Context _context;

        public IndexModel(FinalProjectGameWebsite.Models.Context context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public IList<Game> Game {get; set;}

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            Game = await _context.Games.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }

    }
    
}