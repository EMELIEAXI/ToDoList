using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TasksToDo _toDoList;
        public MainWindow()
        {
            InitializeComponent();
            _toDoList = new TasksToDo();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string NyTask = TaskTextBox.Text;
            if (!string.IsNullOrEmpty(NyTask))
            {
                _toDoList.AddTask(NyTask);
                UpdateTaskList();
                TaskTextBox.Clear();
            }
        }

        private void UpdateTaskList()
        {
            TasksListBox.Items.Clear();
            foreach (var NyTask in _toDoList.GetAllTask())
            {
                TasksListBox.Items.Add(NyTask);
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (TasksListBox.SelectedIndex >= 0)
            {
                _toDoList.RemoveTask(TasksListBox.SelectedIndex);
                UpdateTaskList();
            }
        }
    }
}