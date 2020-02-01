using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmartApplication.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmartApplication.Models;

namespace EmartApplication.Controllers
{
        public class ItemController : Controller
        {
            private readonly EmartItemContext _context;

            public ItemController(EmartItemContext context)
            {
                _context = context;
            }
            // GET: Item
            public ActionResult Index()
            {
                return View();
            }

            // GET: Item/Details/5
            public ActionResult Details(int id)
            {
                return View();
            }

            // GET: Item/Create
            public ActionResult Create()
            {
                return View();
            }

            // POST: Item/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Create(IFormCollection collection)
            {
                try
                {
                    // TODO: Add insert logic here

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }

            // GET: Item/Edit/5
            public ActionResult Edit(int id)
            {
                return View();
            }

            // POST: Item/Edit/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Edit(int id, IFormCollection collection)
            {
                try
                {
                    // TODO: Add update logic here

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }

            // GET: Item/Delete/5
            public ActionResult Delete(int id)
            {
                return View();
            }

            // POST: Item/Delete/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Delete(int id, IFormCollection collection)
            {
                try
                {
                    // TODO: Add delete logic here

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
        public IActionResult AddItems()
        {
            return View();
            }
        [HttpPost]
        public IActionResult AddItems(Item i)
        {
            try
            {
                _context.Add(i);
                _context.SaveChanges();
                SubCategory sc = new SubCategory(i.Scid, i.Sname, i.Cid, i.Cname);
                _context.SubCategory.Add(sc);
                _context.SaveChanges();
                return RedirectToAction("CreateDashboard","Sellers");
            }
            catch(Exception)
            {
                ViewBag.message = "Can't add items";
            }
            return View();
        }
        }
    }