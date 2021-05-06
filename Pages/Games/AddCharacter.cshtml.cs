using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using FinalProjectGameWebsite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinalProjectGameWebsite.Pages
{
    public class AddCharacterModel : PageModel
    {
        private readonly ILogger<AddCharacterModel> _logger;
        private readonly Context _context;
        [BindProperty]
        public Character Character {get; set;}
        public SelectList GamesDropDown {get; set;}

        public AddCharacterModel(Context context, ILogger<AddCharacterModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            GamesDropDown = new SelectList(_context.Games.ToList(), "GameId", "Title");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Characters.Add(Character);
            _context.SaveChanges();

            return RedirectToPage(".Index");
        }
    }
}