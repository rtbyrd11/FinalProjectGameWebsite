using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectGameWebsite.Models
{
    public class Game
    {
        public int GameId {get; set;}
        [Required]
        public string Title {get; set;}
        [Required]
        public string Rating {get; set;}
        [Required]
        [StringLength(1000, MinimumLength = 3)]
        public string Description {get; set;}
        public List<Character> Characters {get; set;}
    }
}