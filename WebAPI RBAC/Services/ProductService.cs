using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebAPI_RBAC.ApplicationContext;
using WebAPI_RBAC.Models;

namespace WebAPI_RBAC.Services;

public class ProductService : IProductServices
{
    private readonly ILogger<ProductService> _logger;
    private readonly IMongoCollection<BookModel> _books;

    public ProductService(IOptions<TestDBSettings> testDbSettings, ILogger<ProductService> logger)
    {
        _logger = logger;
        var client = new MongoClient(testDbSettings.Value.ConnectionString);
        var database = client.GetDatabase(testDbSettings.Value.DatabaseName);
        _books = database.GetCollection<BookModel>(testDbSettings.Value.CollectionName);
    }

    public async Task<List<BookModel>> ListBooks()
    { 
        return await _books.Find(_ => true).ToListAsync();
    }

    public async Task<BookModel> AddBook(BookModel book)
    {
        await _books.InsertOneAsync(book);
        return book;
    }
}