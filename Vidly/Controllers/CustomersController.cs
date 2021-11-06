using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        
        //GET: Customers
        public ActionResult Customers()
        {

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1,Name = "Tharunika"},
                new Customer { Id =2, Name = "Madhunika"}

            };


            RandomCustomerViewModel randomCustomerViewModel = new RandomCustomerViewModel()
            {

                Customers = customers
            };

            return View(randomCustomerViewModel);
            

        }
      
        public ActionResult CustomerDetails(int? id)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1,Name = "Tharunika"},
                new Customer { Id = 2, Name = "Madhunika"}

            };

            var temp = customers.Find(customer => customer.Id == id);
            if (customers == null)
            {
                
                return HttpNotFound();
                
            }
            else
            {
                ViewBag.Name = temp.Name;
                return View(ViewBag);
            }

            
        }
        
    }

}




