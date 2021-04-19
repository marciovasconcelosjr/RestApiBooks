using System.Collections.Generic;
using WebApplication1.Model;
using WebApplication1.Model.Base;

namespace WebApplication1.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindByID(long id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long id);
        bool Exists(long id);

    }
}
