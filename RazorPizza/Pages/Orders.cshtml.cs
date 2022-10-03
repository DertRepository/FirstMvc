using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Data;
using RazorPizza.Models;

namespace RazorPizza.Pages
{
    public class OrdersModel : PageModel
    {
        private readonly AppDbContext _context;
        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();
        public OrdersModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            PizzaOrders = _context.PizzaOrders.ToList();
        }
    }
}
