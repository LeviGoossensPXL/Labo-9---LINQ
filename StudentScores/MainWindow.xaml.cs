using System.Collections.Generic;
using System.Windows;
using StudentScores.Data;

namespace StudentScores
{
    public partial class MainWindow : Window
    {
        StudentStore _store;

        public MainWindow()
        {
            InitializeComponent();
            _store = new StudentStore();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultListBox.ItemsSource = _store.AllStudents;
        }
    }
}
