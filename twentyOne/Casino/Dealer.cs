using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C: \Users\Kyla Kozole\Desktop\Repositories\c#.NET\Logs\log.txt", true)) //log the string card, dealing with unmanaged code, have to dispose of afterwards
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0); //removeat is a method of any list, where you pass in an index of where you want to remove
        }
    
    }
}
