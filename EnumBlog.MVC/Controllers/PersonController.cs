using System.Web.Mvc;
using EnumBlog.MVC.Models;

namespace EnumBlog.MVC.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public ActionResult Add()
        {
            var viewModel = new PersonViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Add(PersonViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Process it

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

    }
}
