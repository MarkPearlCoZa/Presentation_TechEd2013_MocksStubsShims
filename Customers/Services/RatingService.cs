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
            throw new ApplicationException("Not Implemented");
        }
    }
}