using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoList2;

namespace TodoList2.Data
{
    public class TodoList2Context : DbContext
    {
        public TodoList2Context (DbContextOptions<TodoList2Context> options)
            : base(options)
        {
        }

        public DbSet<TodoList2.Todo> Todo { get; set; } = default!;
    }
}
