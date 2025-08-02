using System.Collections.Generic;

namespace WpfApp.Services.Interfaces
{
    public interface IDataService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void SaveAll(IEnumerable<T> entities);
    }
}
