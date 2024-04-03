using CONTROL_METAS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CONTROL_METAS.Controllers
{
    public class MetasController : Controller
    {
        // GET: MetasController
        public async Task<ActionResult> Index()
        {
            List<METAS> metas = new List<METAS>();
            HttpClient http = new HttpClient();
            var Dta = await http.GetAsync("https://localhost:44381/api/METAS");
            var ReadStr = await Dta.Content.ReadAsStringAsync();
            metas = JsonConvert.DeserializeObject<List<METAS>>(ReadStr);
            return View(metas);
        }

        // GET: MetasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MetasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MetasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MetasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MetasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MetasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MetasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
