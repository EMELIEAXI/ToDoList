using ToDoList;
namespace TestingToDoList
{
    public class ToDoListTests
    {
        private ToDoListList _todoList;

        public ToDoListTests()
        {
            _todoList = new ToDoListList();
        }
        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            var task = "Test Test";
            _todoList.AddTask(task);
            var tasks = _todoList.GetAllTask();
            Assert.Contains(task, tasks);
        }

        [Fact]
        public void RemoveTask_ShouldRemoveTaskFromList()
        {
            var task = "Test2 - Att ta bort ";
            _todoList.AddTask(task);
            _todoList.RemoveTask(0);
            var tasks = _todoList.GetAllTask();
            Assert.DoesNotContain(task, tasks);
        }

        [Fact]
        public void RemoveTask_InvalidIndex_ShouldNotThrowException()
        {
            var task = "Vaild Task";
            _todoList.AddTask(task);
            _todoList.RemoveTask(10);
            var tasks = _todoList.GetAllTask();
            Assert.Single(tasks);
        }
    }
}