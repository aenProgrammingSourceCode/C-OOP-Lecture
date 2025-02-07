using nurAPI.Features.DataAccess.MicroServiceDbContext;
using WebApplicationProduct.Features.DataAccess.RepositoryInterface;

namespace WebApplicationProduct.Features.DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericeRepository<T> where T : class
    {
        private AppDbContext _context;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Add(T entity)
        {
          await _context.Set<T>().AddAsync(entity);
          await _context.SaveChangesAsync();
        }
    }
}
