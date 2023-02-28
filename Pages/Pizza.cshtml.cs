using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPizza.Models;
using RazorPagesPizza.Services;

namespace RazorPagesPizza.Pages;

public class PizzaModel : PageModel
{
    public List<Pizza> pizzas = new();
    [BindProperty]
    public Pizza NewPizza { get; set; } = new();

    public void OnGet()
    {
        pizzas = PizzaService.GetAll();
    }

    public string ComOuSemBorda(Pizza pizza)
    {
        return pizza.Borda ? "Com borda" : "Sem borda";
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        PizzaService.Add(NewPizza);
        return RedirectToAction("Get");
    }

    public IActionResult OnPostDelete(int id)
    {
        PizzaService.Delete(id);
        return RedirectToAction("Get");
    }
}

