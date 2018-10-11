using MultipleApplications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultipleApplications.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View("CustomersForm");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if(customer.Id==0)
            {
                _context.Customers.Add(customer);                
            }
            else
            {
                var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == customer.Id);

                customerInDb.Ime = customer.Ime;
                customerInDb.Prezime = customer.Prezime;
                customerInDb.JMBG = customer.JMBG;
                customerInDb.Adresa = customer.Adresa;
                customerInDb.Telefon = customer.Telefon;
                customerInDb.Status = customer.Status;
                customerInDb.TeorijskaObuka = customer.TeorijskaObuka;
                customerInDb.TeorijskiIspit = customer.TeorijskiIspit;
                customerInDb.PrakticnaObuka = customer.PrakticnaObuka;
                customerInDb.PrakticanIspit = customer.PrakticanIspit;
                customerInDb.BrojDodatnihCasova = customer.BrojDodatnihCasova;
                customerInDb.PlacenoZaDodatneCasove = customer.PlacenoZaDodatneCasove;
                customerInDb.DaLiKoristiAkciju = customer.DaLiKoristiAkciju;
                customerInDb.AkcijskaCena = customer.AkcijskaCena;
                customerInDb.PlacenoSve = customer.PlacenoSve;

            }


            _context.SaveChanges();
            return View("Index");
        }


        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

                 if (customer == null)
                return HttpNotFound();

            return View("CustomersForm", customer);
        }
    }
}