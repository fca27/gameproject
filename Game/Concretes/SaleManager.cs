using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstracts;
using GameProject.Entities;
using GameProject.Entity;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void sell(Customer customer, Game game)
        {
            Console.WriteLine(customer.firstName + " " + game.name + " aldı " + 
                game.price + " tl");
        }

        public void sell(Customer customer, Game game, Campaign campaign)
        {
            Console.WriteLine(customer.firstName + " " + game.name + " kampanyalı aldı. " +
                game.price + " tl");
        }
    }
}
