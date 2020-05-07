using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Admins.Models;
using System.Net.Http.Headers;

namespace Admins.Controllers
{
    public class AdminsController : Controller
    {
        private ApplicationDbContext _context;

        public AdminsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {   
            _context.Dispose();
        }

        // GET: Admins
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Enter(LoginAdminsViewModel loginAdmins)
        {
            var user = _context.Employees.SingleOrDefault(
                u => u.phone == loginAdmins.phone && u.password == loginAdmins.Password);
            if (user == null)
            {
                return RedirectToAction("Login","Admins");
                //return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }


            return RedirectToAction("Home","Admins");
        }

      

        

        public ActionResult Home()
        {

            var emoloyees = _context.Employees.Include(m => m.Department).Where(c=>c.name != "Admin").ToList();
            return View(emoloyees);
        }

        public ActionResult Details(int id)
        {
            
            var emp = _context.Employees.Include(m=>m.Department).Single(m=>m.id == id);
            var dep = _context.Departments.Single(m => m.id == emp.deparetmentId);
            ViewData["dep"] = dep.name;
            return View(emp);
        }
    }
}