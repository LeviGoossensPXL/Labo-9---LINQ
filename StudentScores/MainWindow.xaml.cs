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
            MessageBox.Show(
                $"het totaal aantal student: {generalSummary.TotalStudentsCount}" +
                $" - minimum score: {generalSummary.MinScore}" +
                $" - maximum score: {generalSummary.MaxScore}" +
                $" - gemiddelde score: {generalSummary.AvgScore}");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"het aantal departementen: {_store.GetDepartmentCount()}");
        }
    }
}
