using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProjectGameWebsite.Models
{
    public class Character
    {
        public int CharacterId {get; set;}
        [Required]
        public string Name {get; set;}
        [Required]
        public string WeaponOfChoice {get; set;}
        [Required]
        public Game Game {get; set;}
        public int GameId {get; set;}
    }
}