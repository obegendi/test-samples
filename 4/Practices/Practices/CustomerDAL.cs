using Practices.Models;
using System;

namespace Practices
{
    public class CustomerDAL
    {
        public bool Add(Customer customer)
        {            
            if(string.IsNullOrEmpty(customer.Name) && string.IsNullOrEmpty(customer.Surname))
            {
                //Fail
                return false;
            }
            else
            {
                //Add logic                
                return true;
            }
        }
    }
}
