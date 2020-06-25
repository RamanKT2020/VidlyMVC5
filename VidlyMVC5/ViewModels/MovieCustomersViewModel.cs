using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMVC5.Models;

namespace VidlyMVC5.ViewModels
{
    public class MovieCustomersViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}