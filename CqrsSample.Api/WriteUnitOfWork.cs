using CqrsSample.Api.Contracts;
using CqrsSample.Api.Contracts.Repository;
using CqrsSample.Api.Entities;
using CqrsSample.Api.Repository;
namespace CqrsSample.Api;

public class WriteUnitOfWork: IWriteUnitOfWork
{
    private readonly ProdcutDbContext dbContext;
    public WriteUnitOfWork(ProdcutDbContext _dbContext)
    {
        dbContext = _dbContext;
    }
    private WriteProductRepository _writeProductRepository;
    public IWriteProductRepository WriteProductRepository
    {
        get
        {
            return _writeProductRepository ??= new WriteProductRepository(dbContext);
        }
    }
}
