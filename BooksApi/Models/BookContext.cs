using BooksApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Models;

public class BookContext(DbContextOptions<BookContext> options) : DbContext(options)
{
    public DbSet<Book> Books { get; set; } = null!;
}