using DemoBlazorServerBookDatabase.Models;

namespace DemoBlazorServerBookDatabase.BookServices
{
    public interface IBookService
    {
        Task<(bool Success, string Message)> ManageBookAsync(Book book);
        Task<(bool Success, string Message)> DeleteBookAsync(int id);
        Task<List<Book>> GetBookAsync();
    }
}
