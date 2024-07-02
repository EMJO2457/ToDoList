using System.Data;
using System.Data.Common;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDBContext();

            var cont = new ToDoController();



            var NewMaster = (from T in context.ToDoList
                            where T.Status != "completed"
                             select T).ToList(); 

            




            cont.UpdateStatus(Master, 2, context);

            
          

            var ToDo = cont.GetToDo(Master, 1);

            Console.WriteLine(ToDo.Status);

            cont.UpdateStatus(Master, 2, context);
           

            Console.WriteLine(ToDo.Status);
        }
    }
}
