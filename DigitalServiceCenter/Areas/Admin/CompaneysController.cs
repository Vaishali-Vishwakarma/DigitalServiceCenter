using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigitalServiceCenter.Areas.Admin
{
    public class CompaneysController : Controller
    {
        // GET: CompaneysController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CompaneysController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CompaneysController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CompaneysController/Create
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

        // GET: CompaneysController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CompaneysController/Edit/5
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

        // GET: CompaneysController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CompaneysController/Delete/5
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
