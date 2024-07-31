using CqrsSample.Api.Contracts.Repository;

namespace CqrsSample.Api.Repository;

public class ReadProductRepository: IReadProductRepository
{
    private readonly ProdcutDbContext _context;
    public ReadProductRepository(ProdcutDbContext context)
    {
        _context = context;
    }
}
