using GameProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entity
{
    public class Customer:IEntity
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public long nationalIdentityNumber { get; set; }
        public DateTime dateofBirth { get; set; }
    }
}
