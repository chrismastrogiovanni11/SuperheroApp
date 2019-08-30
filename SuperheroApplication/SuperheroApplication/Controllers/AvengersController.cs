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

            //LINQ Query to get data
            //var Superheroes = from superhero in Avengers
            //    select superhero;

            var superheroes = context.Superheroes.ToList();
             
            return View(superheroes);
        }

        // GET: Avengers/Details/5
        public ActionResult Details(int id)
        {

            var superhero = context.Superheroes.Where(s => s.Id == id).Single();
            return View(superhero);
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

                // TODO: Add insert logic here
                context.Superheroes.Add(superhero);
                context.SaveChanges();
                return RedirectToAction("Create");

        }

        // GET: Avengers/Edit/5
        public ActionResult Edit(int id)
        {
            var superhero = context.Superheroes.Where(s => s.Id == id).Single();
            return View(superhero);
        }

        // POST: Avengers/Edit/5
        [HttpPost]
        public ActionResult Edit(Superhero superhero)
        {


                // TODO: Add update logic here
                var SuperheroInDB = context.Superheroes.Single(h => h.Id == superhero.Id);
                SuperheroInDB.PrimaryAbility = superhero.PrimaryAbility;
                SuperheroInDB.SecondaryAbility = superhero.SecondaryAbility;
                SuperheroInDB.SuperheroName = superhero.SuperheroName;
                SuperheroInDB.AlterEgoName = superhero.AlterEgoName;
                SuperheroInDB.CatchPhrase = superhero.CatchPhrase;
                     context.SaveChanges();
                     return RedirectToAction("Index");



        }

        // GET: Avengers/Delete/5
        public ActionResult Delete(int id)
        {
            var Superhero = context.Superheroes.Where(s => s.Id == id).FirstOrDefault();
            return View(Superhero);
        }

        // POST: Avengers/Delete/5
        [HttpPost]
        public ActionResult Delete(Superhero superhero)
        {

                // TODO: Add delete logic here
                var hero = context.Superheroes.Where(s => s.Id == superhero.Id).FirstOrDefault();
                context.Superheroes.Remove(hero);
                context.SaveChanges();
                return RedirectToAction("Index");


        }
    }
}