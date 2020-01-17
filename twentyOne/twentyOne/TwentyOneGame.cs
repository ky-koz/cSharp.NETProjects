using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyOne
{
    public class TwentyOneGame : Game, IWalkAway //this means class TwentyOneGame will inherit from class Game
    {
        public override void Play() //in order to inherit the abstract method, use the same name, data type, parameters, and the override keyword
        {
            throw new NotImplementedException(); //this is a catch until we define this method
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    } 
}
