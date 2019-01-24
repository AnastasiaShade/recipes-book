using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using recipes_book.Models;

namespace recipes_book.Controllers
{
    public class RecipesController : Controller
    {
        private RecipesBookContext db = new RecipesBookContext();

        public ActionResult FirstDishes()
        {
            var recipes = db.Recipes.Where(u => u.Category == Category.FIRST_DISHES).ToList();
            return View(recipes);
        }

        public ActionResult SecondDishes()
        {
            var recipes = db.Recipes.Where(u => u.Category == Category.SECOND_DISHES).ToList();
            return View(recipes);
        }

        public ActionResult Salads()
        {
            var recipes = db.Recipes.Where(u => u.Category == Category.SALADS).ToList();
            return View(recipes);
        }

        public ActionResult BakeryProducts()
        {
            var recipes = db.Recipes.Where(u => u.Category == Category.BAKERY_PRODUCTS).ToList();
            return View(recipes);
        }

        public ActionResult Desserts()
        {
            var recipes = db.Recipes.Where(u => u.Category == Category.DESSERTS).ToList();
            return View(recipes);
        }

        public ActionResult Snacks()
        {
            var recipes = db.Recipes.Where(u => u.Category == Category.SNACKS).ToList();
            return View(recipes);
        }

        public ActionResult Drinks()
        {
            var recipes = db.Recipes.Where(u => u.Category == Category.DRINKS).ToList();
            return View(recipes);
        }

        public ActionResult Other()
        {
            var recipes = db.Recipes.Where(u => u.Category == Category.OTHER).ToList();
            return View(recipes);
        }

        public ActionResult Recipe(Recipe recipe)
        {
            return View(recipe);
        }

        public ActionResult AddRecipeForm()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddRecipeForm(Recipe recipe)
        {
            try
            {
                if (!RecipeFieldsNotEmply(recipe))
                {
                    ModelState.AddModelError("", "Заполните все обязательные поля");
                }

                if (ModelState.IsValid)
                {
                    recipe.UserID = int.Parse(Session["UserId"].ToString());
                    db.Recipes.Add(recipe);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception err)
            {
                ModelState.AddModelError("", "Невозможно добавить рецепт");
            }
            return View(recipe);
        }

        private bool RecipeFieldsNotEmply(Recipe recipe)
        {
            return recipe.Title != null && recipe.Description != null && recipe.CookingTime != null && recipe.Ingredients != null && recipe.Parts != null && recipe.RecipeDescription != null;
        }
    }
}