using VjetEcommerce.Data.Infrastructure;
using VjetEcommerce.Model.Models;

namespace VjetEcommerce.Data.Repositories
{
    public interface IOrderRepository: IRepository<Order>
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}