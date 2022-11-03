using Microsoft.EntityFrameworkCore;
using WebApplication2.Context;
using WebApplication2.Repository.IRepo;

namespace WebApplication2.Repository.Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DoorContext _context;
        DbSet<T> _table;
        public Repository(DoorContext context)
        {
            this._context = context;
            _table=_context.Set<T>();

        
        }

        public int Delete(int id)
        {
            _table.Remove(_table.Find(id));
            return _context.SaveChanges();
        }

        public int Insert(T added)
        {
           _table.Add(added);
            return _context.SaveChanges();

        }

        public List<T> Select(T entity)
        {
            return _table.ToList();
        }

        public T SelectByID(int id)
        {
            return _table.Find(id);
        }

        public int Update(T updated)
        {
            _table.Attach(updated);
            _context.Entry(updated).State = EntityState.Modified;
            return _context.SaveChanges();

        }

 
    }
}
