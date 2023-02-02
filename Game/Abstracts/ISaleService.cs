using GameProject.Entities;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstracts
{
    public interface ISaleService
    {
        public void sell(Customer customer, Game game);
        public void sell(Customer customer, Game game, Campaign campaign);
        
    }
}
