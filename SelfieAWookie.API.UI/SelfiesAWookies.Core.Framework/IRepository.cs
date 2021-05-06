namespace SelfiesAWookies.Core.Framework
{
    public interface IRepository
    {
        IUnitOfWork UnitOfWork { get; }
    }
}