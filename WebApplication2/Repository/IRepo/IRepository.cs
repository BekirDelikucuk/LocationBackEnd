namespace WebApplication2.Repository.IRepo
{
    public interface IRepository<T> where T : class
    {
        List<T> Select(T entity);
        int Insert(T added);
        int Update(T updated);
        int Delete(int id);
        T SelectByID(int id);

    }
}
