using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Lab2Sophie_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetSalaryEmployee_Click(object sender, RoutedEventArgs e)
        {
            if(tbEmployeeName.Text.Trim().Length > 0 &&
                double.TryParse(tbEmployeeKCoef.Text, out double kCoef) &&
                double.TryParse(tbEmployeePCoef.Text, out double pCoef))
            {
                Employee employee = new Employee(tbEmployeeName.Text, pCoef);
                MessageBox.Show($"Employee {employee.Name}. Your salary: ${Math.Round(employee.GetIncome(kCoef), 2)}", "Result!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Invalid data!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnGetSalaryEngineer_Click(object sender, RoutedEventArgs e)
        {
            if (tbEngineerName.Text.Trim().Length > 0 &&
               double.TryParse(tbEngineerKCoef.Text, out double kCoef) &&
               double.TryParse(tbEngineerPCoef.Text, out double pCoef) &&
               int.TryParse(tbEngineerNumberOfProj.Text, out int countOfProj))
            {
                Engineer engineer = new Engineer(tbEngineerName.Text, pCoef, countOfProj);
                MessageBox.Show($"Engineer {engineer.Name}. Your salary: ${Math.Round(engineer.GetIncome(kCoef), 2)}", "Result!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Invalid data!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
