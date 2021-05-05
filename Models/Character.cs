using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectGameWebsite.Models
{
    public class Character
    {
        public int CharacterId {get; set;}
        [Required]
        public string Name {get; set;}
        public string WeaponOfChoice {get; set;}
        public List<GameCharacter> GameCharacters {get; set;}
    }
}