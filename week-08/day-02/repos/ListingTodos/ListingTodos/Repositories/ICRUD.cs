using System.Collections.Generic;

namespace ListingTodos.Repositories
{
    public interface ICRUD<Type>
    {
        void Create(Type element);
        List<Type> ReadAllElements();
        void Update(Type element);
        void Delete(Type element);
    }
}