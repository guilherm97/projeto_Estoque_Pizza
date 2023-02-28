using RazorPagesPizza.Models;

namespace RazorPagesPizza.Services;

public static class PizzaService
{
    static List<Pizza> Pizzas { get; }
    static int nextId = 3;
    static PizzaService()
    {
        Pizzas = new List<Pizza>                
                {
                    new Pizza { Id = 1, Nome = "Classic Italian", Preco=20.00M, Tamanho=TamanhoDePizzas.media, Borda = false },
                    new Pizza { Id = 2, Nome = "Veggie", Preco=15.00M, Tamanho=TamanhoDePizzas.pequena, Borda = true }
                
                };
    }
    public static List<Pizza> GetAll() => Pizzas;
    public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);
    public static void Add(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzas.Add(pizza);
    }
    public static void Delete(int id)
    {
        var pizza = Get(id);
        if (pizza is null)
            return;
        Pizzas.Remove(pizza);
    }
    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
        if (index == -1)
            return;
        Pizzas[index] = pizza;
    }
}