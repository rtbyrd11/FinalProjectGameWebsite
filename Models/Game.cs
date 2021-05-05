using System;
using System.Collections.Generic;

namespace FinalProjectGameWebsite.Models
{
    public class Game
    {
        public int GameId {get; set;}
        public string Title {get; set;}
        public string Rating {get; set;}
        public List<Character> Characters {get; set;}
        public int CharacterId {get; set;}
    }
}