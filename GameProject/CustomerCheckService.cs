using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CustomerCheckService : ICustomerCheckService
    {
        public bool Validate(Customer customer)
        {
            return true;
        }

        
    }
}
