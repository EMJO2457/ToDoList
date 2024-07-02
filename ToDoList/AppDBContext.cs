using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class AppDBContext:DbContext
    {
        public DbSet<ToDo_List> ToDoList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost\\sqlexpress01;" +
            "database=ToDoList;" + "trusted_connection=true;" +
            "trustServerCertificate=true;";


            optionsBuilder.UseSqlServer(connectionString);


            base.OnConfiguring(optionsBuilder);
        }
        public AppDBContext() { }







    }
}
