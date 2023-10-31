using WebApiDemo.Data;
using WebApiDemo.Models;

namespace WebApiDemo.Repositories
{
    public class BookRepository : IBookRepository
    {


        private readonly ApplicationDbContext db;

        public BookRepository(ApplicationDbContext db)
        {

            this.db = db;
        }

        public int AddBook(Book book)
        {
            db.Books.Add(book);
            int result = db.SaveChanges();
            return result;
        }

        public int DeleteBook(int id)
        {
            int res = 0;
            var result = db.Books.Where(x => x.Id == id).FirstOrDefault();
            if (result != null)
            {
                db.Books.Remove(result); // remove from DbSet
                res = db.SaveChanges();
            }

            return res;
        }

        public Book GetBookById(int id)
        {
            var result = db.Books.Where(x => x.Id == id).SingleOrDefault();
            return result;
        }

        public IEnumerable<Book> GetBooks()
        {
            return db.Books.ToList();
        }

        public int UpdateBook(Book book)
        {
            int res = 0;
            var result = db.Books.Where(x => x.Id == book.Id).FirstOrDefault();

            if (result != null)
            {
                result.Name = book.Name;
                result.Author = book.Author;
                result.Price = book.Price;

                res = db.SaveChanges();
            }

            return res;
        }

    }
}
