using BookBlazor.Models;

namespace BookBlazor.Repository
{
	public interface IBookRepository
	{
		public Task<List<Book>> GetBooks();
		public Task<Book> GetBookById(int id);
		public Task<Book> GetBookByName(string name);
		public Task<Book> AddBook(Book book);
		public Task<Book> UpdateBook(int id, Book book);
		public Task DeleteBook(int id);
	}
}
