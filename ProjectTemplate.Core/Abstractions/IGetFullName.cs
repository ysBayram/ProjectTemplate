namespace ProjectTemplate.Core.Abstractions
{
    public interface IGetFullName<TEntity>
    {
        string GetFullName(TEntity entity);
    }
}
