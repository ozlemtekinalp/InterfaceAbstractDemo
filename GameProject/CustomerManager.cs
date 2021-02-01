using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CustomerManager
    {
        ICustomerCheckService customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            this.customerCheckService = customerCheckService;
        }

        public void Add(Customer customer)
        {
            if (customerCheckService.Validate(customer) == true)
            { Console.WriteLine("Oyuncu eklendi:" + customer.FirstName + " " + customer.LastName); }
            else { Console.WriteLine("Oyuncu eklenemedi"); }
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
