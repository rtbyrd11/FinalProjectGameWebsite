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
    public class DetailsModel : PageModel
    {
        private readonly FinalProjectGameWebsite.Models.Context _context;
        public DetailsModel(FinalProjectGameWebsite.Models.Context context)
        {
            _context = context;
        }

        public Game Game {get; set;}
        
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            Game = await _context.Games.Include(g => g.Characters).FirstOrDefaultAsync(g => g.GameId == id);

            if (Game == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPostDeleteReview(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Game = _context.Games.Include(g => g.Characters).FirstOrDefault(g => g.GameId == id);

            return Page();
        }
    }
}