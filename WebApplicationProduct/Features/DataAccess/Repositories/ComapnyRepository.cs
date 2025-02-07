using nurAPI.Features.DataAccess.MicroServiceDbContext;
using nurAPI.Features.DomainModels;
using WebApplicationProduct.Features.DataAccess.RepositoryInterface;

namespace WebApplicationProduct.Features.DataAccess.Repositories
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(AppDbContext context):base(context)
        {
            
        }
    }
}
