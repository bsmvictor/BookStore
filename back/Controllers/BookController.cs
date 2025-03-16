
// Esse controller é responsável por gerir as requisições relacionadas a livros.
// Nele contemos todos os métodos necessários para realizar operações CRUD.
// Possui as requisições GET, POST, PUT e DELETE.
// Para acessar os métodos, utilize a URL base da API e adicione /api/book.

using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
using BookStore.Data;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private readonly LibraryDbContext _context; // Contexto do banco de dados
    
    public BookController(LibraryDbContext context)
    {
        _context = context; // Injeta o contexto do banco de dados
    }
    
    // Retorna todos os livros do banco de dados
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Book>>> GetAllBooks()
    {
        try
        {
            var books = await _context.Books.ToListAsync();                         // Busca todos os livros
            return books.Count > 0 ? Ok(books) : NotFound("Nenhum livro encontrado.");    // Retorna os livros ou uma mensagem de erro
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro no servidor: {ex.Message}");
        }
    }
    
    // Pesquisa um livro pelo ID
    [HttpGet("{id}")]
    public async Task<ActionResult<Book>> GetBook(int id)
    {
        try
        {
            var book = await _context.Books.FindAsync(id);                          // Busca o livro pelo ID
            return book != null ? Ok(book) : NotFound("Livro não encontrado."); // Retorna o livro ou uma mensagem de erro
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro no servidor: {ex.Message}");
        }
    }
    
    // Pesquisa livros por categoria
    [HttpGet("category/{category}")]
    public async Task<ActionResult<Book>> GetBookByCategory(string category)
    {
        try
        {
            var books = await _context.Books.Where(book => book.category.ToLower() == category.ToLower()).ToListAsync(); // Busca os livros pela categoria ignorando case
            return books.Count > 0 ? Ok(books) : NotFound("Nenhum livro encontrado."); // Retorna os livros ou uma mensagem de erro
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro no servidor: {ex.Message}");
        }
    }
    
    // Adiciona um novo livro
    [HttpPost]
    public async Task<ActionResult<Book>> AddBook(Book book)
    {
        try
        {
            _context.Books.Add(book);       // Adiciona o livro
            await _context.SaveChangesAsync(); // Salva as alterações no banco de dados
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book); // Retorna o livro adicionado
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro no servidor: {ex.Message}");
        }
    }
    
    // Atualiza um livro existente
    [HttpPut("{id}")]
    public async Task<ActionResult<Book>> UpdateBook(int id, Book book)
    {
        if (id != book.Id) // Verifica se o ID do livro é válido
        {
            return BadRequest("ID do livro inválido.");
        }
        
        try
        {
            _context.Entry(book).State = EntityState.Modified; // Atualiza o livro
            await _context.SaveChangesAsync(); // Salva as alterações no banco de dados
            return NoContent(); // Retorna uma resposta vazia
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro no servidor: {ex.Message}");
        }
    }
    
    // Deleta um livro existente
    [HttpDelete("{id}")]
    public async Task<ActionResult<Book>> DeleteBook(int id)
    {
        try
        {
            var book = await _context.Books.FindAsync(id); // Busca o livro pelo ID
            if (book == null) // Verifica se o livro existe
            {
                return NotFound("Livro não encontrado.");
            }
            
            _context.Books.Remove(book); // Remove o livro
            await _context.SaveChangesAsync(); // Salva as alterações no banco de dados
            return NoContent(); // Retorna uma resposta vazia
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro no servidor: {ex.Message}");
        }
    }

}