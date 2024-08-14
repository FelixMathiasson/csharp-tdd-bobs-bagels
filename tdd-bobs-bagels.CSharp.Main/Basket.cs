using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<string> orderedBagels = new List<string>();
        private int basketSize = 5; // 5 just as a starting 

        public bool AddBagel(string name)
        {
           if(orderedBagels.Count < basketSize) //still space left
           {
                orderedBagels.Add(name);
                return true;
           }
            Console.WriteLine("Could not add bagel to basket! Basket already full!");
            return false;
        }

        public bool DoesBagelExist(string name)
        {
            if(orderedBagels.Contains(name))
            {
                return true; //bagel exists
            }
            return false; // bagel does not exist
        }

        public bool IsBasketFull()
        {
            if(orderedBagels.Count < basketSize) //basket not full
            {
                return true;
            }
            return false;
        }

        public bool RemoveBagel(string name)
        {
            if (orderedBagels.Contains(name)) // if bagel exists
            {
                orderedBagels.Remove(name);
                return true;
            }
            Console.WriteLine("Could not remove bagel from basket! 404 bagel not found!");
            return false;
        }
    }
}
