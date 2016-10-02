using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomersIndexViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }
    }
}
