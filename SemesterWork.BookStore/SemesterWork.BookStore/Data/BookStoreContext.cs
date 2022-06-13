using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SemesterWork.BookStore.Models;

namespace SemesterWork.BookStore.Data
{
    public class BookStoreContext : IdentityDbContext<ApplicationUser>
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }
        public DbSet<BookGallery> BookGalleries { get; set; }
        public DbSet<Language> Language { get; set; }


    }
}
