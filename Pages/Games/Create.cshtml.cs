using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using FinalProjectGameWebsite.Models;
using FinalProjectGameWebsite.Pages.Games;
using Microsoft.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProjectGameWebsite.Pages.Games
{
    public class CreatePageModel : PageModel
    {
        private readonly FinalProjectGameWebsite.Models.Context _context;
        public CreatePageModel(FinalProjectGameWebsite.Models.Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public Game Game {get; set;}

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Games.Add(Game);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
