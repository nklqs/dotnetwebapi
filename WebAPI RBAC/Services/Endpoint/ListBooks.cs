using WebAPI_RBAC.Endpoint;
using WebAPI_RBAC.Models;

namespace WebAPI_RBAC.Services;

public class ListBooks : IEndpoint
{
    private IProductServices _services;

    public ListBooks(IProductServices services)
    {
        _services = services;
    }

    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("listBooks", async () =>
        {
            var query = await _services.ListBooks();
            return Results.Ok(query);
        });
    }
}