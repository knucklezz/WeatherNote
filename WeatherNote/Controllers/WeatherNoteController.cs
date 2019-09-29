using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeatherNote.Controllers
{
    public class WeatherNoteController : Controller
    {
        // GET: WeatherNote
        public ActionResult Index()
        {
            return View();
        }

        // GET: WeatherNote/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WeatherNote/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WeatherNote/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: WeatherNote/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WeatherNote/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: WeatherNote/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WeatherNote/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
