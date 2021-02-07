using Odev3gun;
using System;

namespace Odevler
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {Id = 1, Adi = "Ahmet", Soyadi = "Yağız", TcNo = "12345678945" }
            Customer customer2 = new Customer() { Id = 2, Adi = "Ayşe", Soyadi = "Şeker", TcNo = "54412156489421" }
            Customer customer3 = new Customer() { Id = 3, Adi = "Şeyma", Soyadi = "Buket", TcNo = "546498321689" }

            CustomerManager customerManager = new CustomerManager();

            Customer[] customers = new Customer[] {customer1,customer2,customer3}


            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            customerManager.Listing(customers);

            customerManager.Remove(customer1);
        }
    }
}
