using System.ComponentModel.DataAnnotations;
using RazorPagesPizza.Models;
using RazorPagesPizza.Services;

namespace RazorPagesPizza.Models;



public class Pizza
{
    public int Id { get; set; }

    [Required]
    public string? Nome { get; set; }
    public TamanhoDePizzas Tamanho { get; set; }
    public bool Borda { get; set; }

    [Range(0.01, 9999.99)]
    public decimal Preco { get; set; }
}

public enum TamanhoDePizzas { pequena, media, grande }
