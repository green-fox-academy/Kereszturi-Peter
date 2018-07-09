using ListingTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Repositories
{
    public class TodoRepository : ICRUD<Todo>
    {
        private TodoContext todoDBContext;

        public TodoRepository(TodoContext todoDBContext)
        {
            this.todoDBContext = todoDBContext;
        }

        public void Create(Todo element)
        {
            todoDBContext.Add(element);
            todoDBContext.SaveChanges();
        }

        public void Delete(Todo element)
        {
            todoDBContext.Remove(element);
            todoDBContext.SaveChanges();
        }

        public List<Todo> ReadAllElements()
        {
            return todoDBContext.Todos.ToList();
        }

        public void Update(Todo element)
        {
            todoDBContext.Update(element);
            todoDBContext.SaveChanges();
        }
    }
}
