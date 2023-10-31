using WebApiDemo.Models;

namespace WebApiDemo.Sevices
{
    public interface IBookService
    {

        IEnumerable<Book> GetBooks();

        Book GetBookById(int id);

        int AddBook(Book book);
        int UpdateBook(Book book);

        int DeleteBook(int id);



    }
}
