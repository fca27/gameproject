using GameProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Campaign:IEntity
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
