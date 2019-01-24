using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace recipes_book.Models
{
    public enum Difficulty
    {
        [Display(Name = "Легко")]
        EASY,
        [Display(Name = "Средне")]
        MIDDLE,
        [Display(Name = "Сложно")]
        HARD
    }

    public enum Category
    {
        [Display(Name = "Первые блюда")]
        FIRST_DISHES,
        [Display(Name = "Вторые блюда")]
        SECOND_DISHES,
        [Display(Name = "Салаты")]
        SALADS,
        [Display(Name = "Выпечка")]
        BAKERY_PRODUCTS,
        [Display(Name = "Десерты")]
        DESSERTS,
        [Display(Name = "Закуски")]
        SNACKS,
        [Display(Name = "Напитки")]
        DRINKS,
        [Display(Name = "Другое")]
        OTHER
    }

    public class Recipe
    {
        [Key]
        public int ID { get; set; }

        public int UserID { get; set; }

        [Display(Name = "Название*")]
        public string Title { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Категория")]
        public Category Category { get; set; }

        [Display(Name = "Время приготовления (в минутах)*")]
        public string CookingTime { get; set; }

        [Display(Name = "Количество порций*")]
        public string Parts { get; set; }

        [Display(Name = "Сложность")]
        public Difficulty Difficulty { get; set; }

        [Display(Name = "Ингредиенты*")]
        public string Ingredients { get; set; }

        [Display(Name = "Рецепт*")]
        public string RecipeDescription { get; set; }
    }
}