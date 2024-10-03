using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void customerInsert(Customer customer)
        {
            Console.WriteLine(customer.name+" eklendi..");
        }

        public void customerList(Customer[] customers)
        {
            foreach(Customer customer in customers)
            {
                Console.WriteLine(customer.name + " " + customer.surname);
            }
        }
        public void customerDelete(Customer customer)
        {
            Console.WriteLine(customer.name + " Kişisi artık müşteri değildir.");
        }
    }
}
