using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly List<Customer> _customers;
        public CustomersController()
        {
            _customers = new List<Customer>()
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };
        }

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new CustomersIndexViewModel
            {
                Customers = _customers
            };

            return View(viewModel);
        }

        // GET: Customer Detail
        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = _customers.Find(x => x.Id == id);

            if (customer == null)
                return new HttpNotFoundResult();

            return View(customer);
        }
    }
}