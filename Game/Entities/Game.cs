using GameProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entity
{
    public class Game:IEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }

    }
}
