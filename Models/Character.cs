using System;
using System.Collections.Generic;

namespace FinalProjectGameWebsite.Models
{
    public class Character
    {
        public int CharacterId {get; set;}
        public string Name {get; set;}
        public string WeaponOfChoice {get; set;}
        public string Description {get; set;}
        public int GameId {get; set;}
        public List<Game> Games {get; set;}
    }
}