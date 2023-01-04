using BookBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace BookBlazor.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
			base (options)
		{
		}

		public DbSet<Book> Books { get; set; }
	}
}
