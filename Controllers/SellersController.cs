using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmartApplication.Models;
using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Hosting;


namespace EmartApplication.Controllers
{
    public class SellersController : Controller
    {
        private readonly EmartSellerContext _context;
        //private readonly IWebHostEnvironment hostingEnvironment;
        //public SellersController(EmartSellerContext context, IWebHostEnvironment hostingEnvironment)
        //{
        //    this._context = context;
        //    this.hostingEnvironment = hostingEnvironment;
        //}


        public SellersController(EmartSellerContext context)
        {
            _context = context;
        }

        //public ActionResult Create(SellerCreateViewModel model)
        //{
        //    if(ModelState.IsValid)
        //    {

        //    }
        //}



        // GET: Sellers/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Seller s)
        {
            try
            {
                _context.Add(s);
                _context.SaveChanges();
                ViewBag.message = s.Name + " has got succesfully registered";
                return RedirectToAction("Login");
            }
            catch (Exception)
            {
                ViewBag.message = s.Name + "Registration failed";
            }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Seller s)
        {
            var logUser = _context.Seller.Where(e => e.Name == s.Name && e.Pwd == s.Pwd);
            if (logUser.Count() == 0)
            {

                ViewBag.message = "Not a valid User";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("Name", s.Name);
                return RedirectToAction("CreateDashBoard");
            }
        }
        public IActionResult CreateDashBoard()
        {
            return View();
        }
        public bool IsExist(string email)
        {
            var res = _context.Seller.Where(e => e.Email==email).ToList();
            if (res.Count == 0)
                return true;
            else
                return false;

        }
    }

   }
