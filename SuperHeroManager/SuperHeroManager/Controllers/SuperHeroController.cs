using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroManager.Data;
using SuperHeroManager.Models;

namespace SuperHeroManager.Controllers
{
    public class SuperHeroController : Controller
    {
        // db
        public ApplicationDbContext _context;
        public SuperHeroController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: SuperHero
        public ActionResult Index()
        {
            // superHero = db.SuperHeros
            var superHero = _context.SuperHeros;
            return View(superHero);
        }

        // GET: SuperHero/Details/5
        public ActionResult Details(int id)
        {
            SuperHero superHero = _context.SuperHeros.Find(id);
            return View(superHero);
        }

        // GET: SuperHero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperHero/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                // TODO: Add insert logic here
                _context.SuperHeros.Add(superHero);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                
                return View();
            }
        }

        // GET: SuperHero/Edit/5
        public ActionResult Edit(int id)
        {

            SuperHero superHero = _context.SuperHeros.Find(id);
            return View(superHero);
        }

        // POST: SuperHero/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            SuperHero superHero = null;
            try
            {
                superHero = _context.SuperHeros.Find(id);
                superHero.name = collection["name"];
                superHero.primaryAbility = collection["primaryAbility"];
                superHero.secondaryAbility = collection["secondaryAbility"];
                superHero.alterEgo = collection["alterEgo"];
                superHero.catchPhrase = collection["catchPhrase"];
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (InvalidOperationException e)
            {
                return View();
            }
        }

        // GET: SuperHero/Delete/5
        public ActionResult Delete(int id)
        {
             SuperHero superHero = _context.SuperHeros.Find(id);
            return View(superHero);
        }

        // POST: SuperHero/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                SuperHero superHero = _context.SuperHeros.Find(id);
                _context.SuperHeros.Remove(superHero);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}