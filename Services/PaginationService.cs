using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
    public abstract class PaginationService<T>
    {
        protected readonly TestDbContext _ctx;

        protected PaginationService(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public PagedList<TEntity> ListItems<TEntity>(int page, int pageSize) where TEntity : class
        {
            var items = new PagedList<TEntity>();
            items.TotalCount = _ctx.Set<TEntity>().Count();
            items.Items = _ctx.Set<TEntity>().Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return items;
        }
    }
}
