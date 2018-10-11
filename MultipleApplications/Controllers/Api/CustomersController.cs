using MultipleApplications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MultipleApplications.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/customers
        public IHttpActionResult GetCustomers()
        {
            var customers = _context.Customers.ToList();

            return Ok(customers);
        }

        //DELETE /api/customers
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

                if(customerInDb == null)
                return BadRequest();

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();

            return Ok();

        }

    

    }
}
