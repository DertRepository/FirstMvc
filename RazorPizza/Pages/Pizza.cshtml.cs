using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel() {ImgTitle = "Bolognese",Name = "Bolognese", BasePrice = 2, TomatoSauce = true, Mushroom = true, FinalPrice=4,Favorite = "I like it much much"},
            new PizzasModel() {ImgTitle = "Carbonara",Name = "Carbonara", BasePrice = 2, TomatoSauce = true, Mushroom = true, FinalPrice=4},
            new PizzasModel() {ImgTitle = "Hawaiian",Name = "Hawaiian", BasePrice = 2, TomatoSauce = true, Mushroom = true, FinalPrice=4},
            new PizzasModel() {ImgTitle = "Margerita",Name = "Margerita", BasePrice = 2, TomatoSauce = true, Mushroom = true, FinalPrice=4},
            new PizzasModel() {ImgTitle = "MeatFeast",Name = "MeatFeast", BasePrice = 2, TomatoSauce = true, Mushroom = true, FinalPrice=4},
            new PizzasModel() {ImgTitle = "Mushroom",Name = "Mushroom", BasePrice = 2, TomatoSauce = true, Mushroom = true, FinalPrice=4},
            new PizzasModel() {ImgTitle = "Pepperoni",Name = "Pepperoni", BasePrice = 2, TomatoSauce = true, Mushroom = true, FinalPrice=4},
            new PizzasModel() {ImgTitle = "Seafood",Name = "Seafood", BasePrice = 2, TomatoSauce = true, Mushroom = true, FinalPrice=4,Favorite = "This is my worse food"},
            new PizzasModel() {ImgTitle = "Vegetarian",Name = "Vegetarian", BasePrice = 2, TomatoSauce = true, Mushroom = true, FinalPrice=4}
        };
        public void OnGet()
        {
        }
    }
}
