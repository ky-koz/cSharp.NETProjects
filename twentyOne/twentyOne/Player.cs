using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public static Game operator+ (Game game, Player player) //(what we are adding together)
        {
            game.Players.Add(player); //(item to add)
            return game;
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player); //(item to remove)
            return game;
        }
    }
}
