using BookBlazor.Data;
using BookBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace BookBlazor.Repository
{
	public class BookRepository : IBookRepository
	{
		private readonly ApplicationDbContext Context;

		public BookRepository(ApplicationDbContext context)
		{
			Context = context;
		}

		public async Task<List<Book>> GetBooks()
		{
			return await Context.Books.ToListAsync();
		}

		public async Task<Book> GetBookById(int id)
		{
			var book = await Context.Books.FindAsync(id);

			if (book is null)
				return new Book();

			return book;
		}

		public async Task<Book> GetBookByName(string name)
		{
			var book = await Context.Books.FindAsync(name);

			if (book is null)
				return new Book();

			return book;
		}

		public async Task<Book> AddBook(Book book)
		{
			await Context.Books.AddAsync(book);
			await Context.SaveChangesAsync();
			return book;
		}
		public async Task<Book> UpdateBook(int id, Book request)
		{
			var book = await Context.Books.FindAsync(id);

			if (book is null)
				return new Book();

			book.Title = request.Title;
			book.Description = request.Description;
			book.Author = request.Author;
			book.Pages = request.Pages;
			book.Price = request.Price;

			await Context.SaveChangesAsync();
			return book;
		}

		public async Task DeleteBook(int id)
		{
			var book = await Context.Books.FindAsync(id);

			Context.Books.Remove(book);
			await Context.SaveChangesAsync();
		}
	}
}
