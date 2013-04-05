using System;
using Customers.Commands;
using Customers.DTO;
using Customers.Repositories;
using Customers.Services;

namespace Customers.ViewModels
{
    public class CustomerViewModel : ViewModelBase
    {
        private Customer _customer;
        private readonly IRatingService _ratingService;
        private readonly ICustomerRepository _customerRepository;
        private DateTime _lastUpdated;

        public AlwaysExecuteCommand SaveCommand { get; private set; }

        public CustomerViewModel(
            Customer customer, 
            IRatingService ratingService, 
            ICustomerRepository customerRepository)
        {
            _customer = customer;
            _ratingService = ratingService;
            _customerRepository = customerRepository;
            SaveCommand = new AlwaysExecuteCommand(Update);
        }

        public string DisplayRate
        {
            get
            {
                var rate = _ratingService.Rate(_customer);
                if (rate == 1) return "Gold";
                return "Ordinary";
            }
        }

        public DateTime DisplayLastUpdated
        {
            get { return _lastUpdated; }
            private set
            {
                if (value != _lastUpdated)
                {
                    _lastUpdated = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Name
        {
            get { return _customer.Name; }
            set
            {
                if (_customer.Name != value)
                {
                    _customer.Name = value;
                    OnPropertyChanged();
                    OnPropertyChanged("DisplayRate");
                }
            }
        }     

        public void Update()
        {
            _customer = _customerRepository.Save(_customer);
            DisplayLastUpdated = DateTime.Now;
        }
    }
}