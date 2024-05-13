

namespace Online_Bookstore.Interfaces
{
    public interface ICrud<T>
    {
        void Create(T entity);
        T Read(int id);
        bool Update(T entity);
        bool Delete(int id);
    }
}
