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

        public List<ToDo_List> GetAll(AppDBContext context)
        {

            var Master = (from T in context.ToDoList
                          where T.Status != "completed"
                          select T).ToList();
            return Master;
        }

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



        public static DateTime setDate()
        {
            // Get the current date and time
            DateTime today = DateTime.Today;

            // Add 7 days to the current date
            DateTime futureDate = today.AddDays(7);

            // Optionally, if you need to include the current time as well:
            DateTime futureDateTime = DateTime.Now.AddDays(7);

            return futureDateTime;
        }
        public void DeleteItem(int id, AppDBContext context)
        {
           

        }

        public void AddToDoList(List<ToDo_List> list, ToDo_List Fred, AppDBContext context)
        {

            Fred.DueDate = setDate();
            list.Add(Fred);
            context.Add(Fred);
            context.SaveChanges();

        }








    }
}
