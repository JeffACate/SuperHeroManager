﻿using System;
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
            return View();
        }

        // POST: SuperHero/Edit/5
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

        // GET: SuperHero/Delete/5
        public ActionResult Delete(int id)
        {
            SuperHero superHero = _context.SuperHeros.Find(id);
            return View(superHero);
        }

        // POST: SuperHero/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(SuperHero superHero, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
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