using System.Text;
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
        private ToDoListList _toDoList;

        public MainWindow()
        {
            InitializeComponent();
            _toDoList = new ToDoListList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string task = TaskTextBox.Text;
            if (!string.IsNullOrEmpty(task))
            {
                _toDoList.AddTask(task);
                UpdateTaskList();
                TaskTextBox.Clear();
            }
        }

        private void UpdateTaskList()
        {
            TasksListBox.Items.Clear();
            foreach (var task in _toDoList.GetAllTask())
            {
                TasksListBox.Items.Add(task);
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