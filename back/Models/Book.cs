
// Essa classe representa o modelo dos dados que serão armazenados no banco de dados.
// Cada instância dessa classe representa um livro.

namespace BookStore.Models;

public class Book
{
    public int Id { get; set; }
    public string title { get; set; }
    public string cover { get; set; }
    public string summary { get; set; }
    public string category { get; set; }
    public double price { get; set; }
}