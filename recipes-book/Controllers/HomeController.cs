using System.Linq;
using System.Web.Mvc;
using recipes_book.Models;

namespace recipes_book.Controllers
{
    public class HomeController : Controller
    {
        private RecipesBookContext db = new RecipesBookContext();

        public ActionResult Index()
        {
            var recipes = db.Recipes.ToList();
            return View(recipes);
        }
    }
}