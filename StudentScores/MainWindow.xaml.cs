using System.Collections.Generic;
using System.Windows;
using StudentScores.Data;
using StudentScores.Entities;

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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            resultListBox.ItemsSource = _store.PassedStudents;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            resultListBox.ItemsSource = _store.StudentsOrderedByName();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            resultListBox.ItemsSource = _store.StudentsGroupedByDepartment();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            GeneralSummary generalSummary = _store.GetGeneralSummary();
            MessageBox.Show($"{generalSummary.TotalStudentsCount} - {generalSummary.MinScore} - {generalSummary.MaxScore} - {generalSummary.AvgScore}");
        }
    }
}
