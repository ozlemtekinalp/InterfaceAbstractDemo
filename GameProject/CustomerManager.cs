using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            CustomerCheckService customerCheckService = new CustomerCheckService();
            customerCheckService.Validate(customer);
            Console.WriteLine("Oyuncu eklendi:"+ customer.FirstName +" "+ customer.LastName);
        }

        public void Delete(Customer customer) {

            Console.WriteLine("Oyuncu silindi:"+ customer.FirstName + " " + customer.LastName);

        
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Oyuncu güncellendi:" + customer.FirstName + " " + customer.LastName);
        }
    }
}
