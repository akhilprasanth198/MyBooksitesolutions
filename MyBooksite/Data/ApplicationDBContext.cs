using Microsoft.EntityFrameworkCore;
using MyBooksite.Models;
using MyBooksite.Data;
namespace MyBooksite.Data
{
    public class ApplicationDBContext : DbContext

    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)    
    {}
    
    public DbSet<Book> Book {  get; set; }
    public DbSet<Author> Author { get; set; }

    public DbSet<Country> Country { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<Book>().HasData
                (

                new Book
                {
                    Id = 2,
                    Title = "Hamlet",
                    price = 800,
                    authorid = 2,
                    language = "english",
                    publishedyear = 2011,
                    subject = "novel",
                    age = 55
                }
                );
            modelBuilder.Entity<Author>().HasData
                (

                new Author
                {
                    AuthorId = 2,
                    Name = "shakespeare",
                    country = "England",
                    primarynumber = 987654321 
                }
                );
		}
	}   
}
