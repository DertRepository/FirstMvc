using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizza.Pages.Checkouts
{
    [BindProperties(SupportsGet =true)]
    public class CheckModel : PageModel
    {
        public string Name { get; set; }
        public float PizzaPrice { get; set; }
        public string ImgTitle { get; set; }
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
        }
    }
}
