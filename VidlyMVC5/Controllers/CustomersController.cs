using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMVC5.Models;
using System.Data.Entity;


namespace VidlyMVC5.Controllers
{
    public class CustomersController : Controller
    {
        //private ApplicationDbContext _context;

        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customers = GetCustomers();
            var customer = customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }


        private IEnumerable<Customer> GetCustomers()
        {
        return new List<Customer>() {
                new Customer() { Id = 1, Name = "Allen Smith" },
                new Customer() { Id = 2, Name = "John Paul" }
            };

        }
    }
}