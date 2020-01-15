using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyOne
{
    public abstract class Game //as an abstract class, cannot instantiate/create an object out of this class
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); //no implementation, abstract method that makes any class inheriting this class, must implement this method

        public virtual void ListPlayers() //a virtual method inside of an abstract class, means that this method gets inerited but has the ability to be overridden
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name); 
            }
        }
    }
}
