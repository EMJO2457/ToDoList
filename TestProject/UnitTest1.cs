using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using ToDoList;

namespace TestProject
{
    public class UnitTest1
    {
        ToDo_List todo = new ToDo_List() { Description="Hello Its me ive been wondering if after all these years youd like to meet to go over everything"};
        ToDoController controller = new ToDoController();
        AppDBContext dbContext = new AppDBContext();


        [Theory]
        [InlineData(80, 800)]



        public void StringLength(int a, int b)
        {
            Assert.True(a <= todo.Description.Length && todo.Description.Length <= b);
        }
        [Fact]


        public void TestAdd()
        {

            var list = controller.GetAll(dbContext);
            controller.AddToDoList(list, todo, dbContext);
            Assert.Contains(todo, list);
        }
        [Fact]
        public void TestUpdate()
        {
            var list = controller.GetAll(dbContext);
            controller.AddToDoList(list, todo, dbContext);

            controller.UpdateStatus(list, todo.ID, dbContext);
            Assert.True(todo.Status == "Completed");

        }
        [Fact]
        public void TestDateTime()
        {
            var list = controller.GetAll(dbContext);
            controller.AddToDoList(list, todo, dbContext);
            Assert.True(todo.DueDate == DateTime.Now.AddDays(7));

        }

        [Fact]
        public void TestGetToDo()
        {
            var list = controller.GetAll(dbContext);
            controller.AddToDoList(list, todo, dbContext);
            Assert.True(todo== controller.GetToDo(list,todo.ID));

        }



    }
}