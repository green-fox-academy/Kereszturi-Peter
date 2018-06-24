using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOAPP2
{
    class Todo
    {
        int ID;
        string text;
        DateTime createdAt;
        DateTime completedAt;

        public int ID1 { get => ID; set => ID = value; }
        public string Text { get => text; set => text = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime CompletedAt { get => completedAt; set => completedAt = value; }

        public Todo(int iD, string text, DateTime createdAt, DateTime completedAt)
        {
            ID1 = iD;
            Text = text;
            CreatedAt = createdAt;
            CompletedAt = completedAt;
        }

    }
}
