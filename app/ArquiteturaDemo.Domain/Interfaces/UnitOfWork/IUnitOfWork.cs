namespace ArquiteturaDemo.Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
    }
}
