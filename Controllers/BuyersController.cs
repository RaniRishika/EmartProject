using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmartApplication.Models;
using Microsoft.AspNetCore.Http;

namespace EmartApplication.Controllers
{
    public class BuyersController : Controller
    {
        private readonly EmartBuyerContext _context;

        public BuyersController(EmartBuyerContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }
        
     [HttpPost]
        
        public IActionResult Create(Buyer b)
        {
            try
            {
                _context.Add(b);
                _context.SaveChanges();
                ViewBag.message = b.Name + " has got succesfully registered";
                return RedirectToAction("Login");
            }
            catch (Exception)
            {
                ViewBag.message = b.Name + "Registration failed";
            }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Buyer b)
        {
            var logUser = _context.Buyer.Where(e => e.Name == b.Name && e.Pwd == b.Pwd);
            if (logUser.Count() == 0)
            {

                ViewBag.message = "Not a valid User";
                return View();
            }
            else
            {
                
                HttpContext.Session.SetString("Name", b.Name);
                return RedirectToAction("CreateDashBoard");
            }
        }
        public IActionResult CreateDashBoard()
        {
            return View();
        }
        public bool IsExist(string email)
        {
            var res = _context.Buyer.Where(e => e.Email == email).ToList();
            if (res.Count == 0)
                return true;
            else
                return false;

        }



    }
}
