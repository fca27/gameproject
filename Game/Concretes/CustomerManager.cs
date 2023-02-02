using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstracts;
using GameProject.Entity;

namespace GameProject.Concrete
{
    public class CustomerManager:ICustomerService
    {
        public void add(Customer customer)
        {
            Console.WriteLine(customer.firstName+" eklendi");
        }
        public void update(Customer customer)
        {
            Console.WriteLine(customer.firstName + " bilgileri güncellendi");
        }
        public void delete(Customer customer)
        {
            Console.WriteLine(customer.firstName + " silindi");
        }
    }
}
