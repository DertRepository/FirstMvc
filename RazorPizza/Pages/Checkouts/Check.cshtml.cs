using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Data;
using RazorPizza.Models;

namespace RazorPizza.Pages.Checkouts
{
    [BindProperties(SupportsGet =true)]
    public class CheckModel : PageModel
    {
        public string Name { get; set; }
        public float PizzaPrice { get; set; }
        public string ImgTitle { get; set; }
        public string Favorite { get; set; }

        private readonly AppDbContext _context;
        public CheckModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImgTitle))
            {
                ImgTitle = "Create";
            }
            if (string.IsNullOrWhiteSpace(Favorite))
            {
                Favorite = "Hmm i just thinking";
            }

            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.Name = Name;
            pizzaOrder.BasePrice = PizzaPrice;
            pizzaOrder.Favorite = Favorite;

            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();
        }
        
    }
}
