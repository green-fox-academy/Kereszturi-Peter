using ListingTodos.Models;
using ListingTodos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Services
{
    public class TodoService : ITodoService
    {
        private TodoRepository todoRepo;

        public TodoService(TodoRepository todoRepo)
        {
            this.todoRepo = todoRepo;
        }

        public void AddTodo(Todo todo)
        {
            todoRepo.Create(todo);
        }

        public List<Todo> GetTodos()
        {
            return todoRepo.ReadAllElements();
        }

        public void ModifyTodo(Todo todo)
        {
            todoRepo.Update(todo);
        }

        public void RemoveTodo(Todo todo)
        {
            todoRepo.Delete(todo);
        }
    }
}
