using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3gun
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Adi + customer.Soyadi + "isimli müşteri eklendi");
        }

        public void Remove (Customer customer)
        {
            Console.WriteLine(customer.Adi + customer.Soyadi + "isimli müşteri silindi");
        }


        public void Listing(Customer[] customers)
        {
            foreach (Customer inform in customers)
            {
                Console.WriteLine(inform.Adi);
            }
        }
    }
}
