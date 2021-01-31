using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICustomerCheckService
    {
        bool Validate(Customer customer);
    }
}
