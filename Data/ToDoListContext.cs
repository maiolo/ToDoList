using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

    public class ToDoListContext : DbContext
    {
        public ToDoListContext (DbContextOptions<ToDoListContext> options)
            : base(options)
        {
        }

        public DbSet<ToDoList.Models.List> List { get; set; } = default!;
    }
