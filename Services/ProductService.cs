using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
	public class ProductService : PaginationService<Product>
	{
        public ProductService(TestDbContext ctx) :base(ctx)
        {
        }

        public PagedList<Product> ListProducts(int page)
		{
			return ListItems<Product>(page, pageSize: 10);
		}

	}
}
