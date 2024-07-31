using CqrsSample.Api.Contracts;
using CqrsSample.Api.Contracts.Repository;
using CqrsSample.Api.Repository;
namespace CqrsSample.Api;

public class ReadUnitOfWork: IReadUnitOfWork
{
    private readonly ProdcutDbContext dbContext;
    private ReadProductRepository _readProductRepository;

    public ReadUnitOfWork(ProdcutDbContext _dbContext)
    {
        dbContext = _dbContext;
    }
    public IReadProductRepository ReadProductRepository
    {
        get
        {
            return _readProductRepository ??= new ReadProductRepository(dbContext);
        }
    }
}
