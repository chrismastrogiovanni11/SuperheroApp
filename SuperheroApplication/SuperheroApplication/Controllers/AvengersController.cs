using SuperheroApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superhero_App.Controllers
{
    public class AvengersController : Controller
    {
        ApplicationDbContext context;

        public AvengersController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Avengers
        public ActionResult Index()
        {
            return View();
        }

        // GET: Avengers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Avengers/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: Avengers/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                context.Avengers.Add(superhero);
                context.SaveChanges();
                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        // GET: Avengers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Avengers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here
                context.Avengers.
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Avengers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Avengers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here
                context.Avengers.Remove(superhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}