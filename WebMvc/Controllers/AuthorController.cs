using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Newtonsoft.Json;

namespace WebMvc.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public ActionResult Index()
        {
            List<Author> lst = new List<Author>();

            try
            {
                //Connect To API using class Helper
                ApiConnector obj = new ApiConnector();
                string result = obj.Get(Constants.APIController_Author);
                // convert Json
                lst = JsonConvert.DeserializeObject<List<Author>>(result);
            }
            catch(Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return View(lst);
        }

        // GET: Author/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Author/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Author/Create
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

        // GET: Author/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Author/Edit/5
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

        // GET: Author/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Author/Delete/5
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
    }
}