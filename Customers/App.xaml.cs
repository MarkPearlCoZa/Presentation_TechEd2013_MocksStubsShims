using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Customers.DTO;
using Customers.Repositories;
using Customers.Services;
using Customers.ViewModels;

namespace Customers
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public ViewModelBase _vm;
        public Window _view;

        public App()
        {
            var cust = new Customer
                {
                    Name = "Mark Pearl",
                    Id = 1
                };

            _vm = new CustomerViewModel(cust, new RatingService(), new CustomerRepository());
            _view = new CustomerView();
            _view.DataContext = _vm;
            _view.ShowDialog();
        }
    }
}
