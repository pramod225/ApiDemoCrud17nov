using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApiClient.Models;

namespace WebApiClient.Controllers
{
    public class ApiUserController : Controller
    {
        // GET: ApiUser
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: ApiUser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApiUser/Create
        public ActionResult Create()
        {
            ApiUser user = new ApiUser();
            return View(user);
        }

        // POST: ApiUser/Create
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

        // GET: ApiUser/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApiUser/Edit/5
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

        // GET: ApiUser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApiUser/Delete/5
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
