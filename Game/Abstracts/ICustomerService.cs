using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstracts
{
    public interface ICustomerService
    {
        public void add(Customer customer);

        public void update(Customer customer);

        public void delete(Customer customer);
        
    }
}
