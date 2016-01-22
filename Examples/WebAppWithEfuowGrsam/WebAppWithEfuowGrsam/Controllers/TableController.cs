using System.Web.Mvc;
using WebAppWithEfuowGrsam.Models;
using WebAppWithEfuowGrsam.Services;

namespace WebAppWithEfuowGrsam.Controllers
{
    public class TableController : Controller
    {
        private TableService service = new TableService();

        // GET: Table
        public ActionResult Index()
        {
            var model = service.GetAll();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TableModel model)
        {
            if (ModelState.IsValid)
            {
                service.Create(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}