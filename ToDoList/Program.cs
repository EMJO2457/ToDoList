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



            var Master = (from T in context.ToDoList
                            where T.Status != "completed"
                             select T).ToList(); 

            




            //cont.UpdateStatus(Master, 3, context);

            
          

            var GToDo = cont.GetToDo(Master, 1);

            Console.WriteLine(GToDo.Status);

            //cont.UpdateStatus(Master, 2, context);

            var toDo = new ToDo_List()
            {
                
            };
            cont.AddToDoList(Master,toDo, context);

            Console.WriteLine(toDo.Status);
        }
    }
}
