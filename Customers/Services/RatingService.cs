using System;
using System.Collections.Generic;
using Customers.DTO;

namespace Customers.Services
{
    public interface IRatingService
    {
        int Rate(Customer customer);
    }

    public class RatingService  : IRatingService
    {
        public int Rate(Customer customer)
        {
            if (customer.Name.Contains("Mark")) return 1;
            return 0;
        }
    }
}