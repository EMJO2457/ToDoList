using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class ToDoController
    {

        public ToDo_List GetToDo(List<ToDo_List> Master, int id)
        {
            foreach (ToDo_List toDo in Master)
            {
                if (id == toDo.ID) { return toDo; }

            }
            return null;

            
        }


        public void UpdateStatus(List<ToDo_List> Master, int id, AppDBContext context)
        {

            {
                ToDo_List toDoToUpdate = GetToDo(Master, id);
                toDoToUpdate.Status = "Completed";

                context.Entry(toDoToUpdate).State = EntityState.Modified;
               

                context.SaveChanges();

            }

        }










    }
}
