using WebAPI_RBAC.Models;

namespace WebAPI_RBAC.Services;

public interface IProductServices
{
    public Task<List<BookModel>> ListBooks();
    public Task<BookModel> AddBook(BookModel book);
}