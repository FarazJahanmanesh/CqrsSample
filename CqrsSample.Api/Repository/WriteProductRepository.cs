using CqrsSample.Api.Contracts.Repository;
namespace CqrsSample.Api.Repository;

public class WriteProductRepository: IWriteProductRepository
{
    private readonly ProdcutDbContext dbContext;
    public WriteProductRepository(ProdcutDbContext _dbContext)
    {
        dbContext = _dbContext;
    }
}
