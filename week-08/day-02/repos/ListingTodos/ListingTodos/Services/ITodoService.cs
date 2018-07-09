using ListingTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Services
{
    public interface ITodoService
    {
        void AddTodo(Todo todo);
        List<Todo> GetTodos();
        void ModifyTodo(Todo todo);
        void RemoveTodo(Todo todo);
    }
}
