using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Models
{
    public class Todo
    {
        private long id;
        private string title;
        private bool isUrgent;
        private bool isDone;

        public long Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public bool IsUrgent { get => isUrgent; set => isUrgent = value; }
        public bool IsDone { get => isDone; set => isDone = value; }
    }
}
