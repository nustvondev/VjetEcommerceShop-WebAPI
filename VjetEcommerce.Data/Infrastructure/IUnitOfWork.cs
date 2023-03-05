namespace VjetEcommerce.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}