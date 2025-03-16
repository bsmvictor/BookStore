
// Esse arquivo é responsável por configurar o DbContext do Entity Framework Core.
// Ele é responsável por mapear as entidades do banco de dados e criar as tabelas.

using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data;

public class LibraryDbContext : DbContext
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }
    
    public DbSet<Book> Books { get; set; }
}