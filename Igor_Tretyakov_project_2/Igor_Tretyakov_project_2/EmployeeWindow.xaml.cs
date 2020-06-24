using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Igor_Tretyakov_project_2
{
    /// <summary>
    /// Логика взаимодействия для EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow()
        {
            InitializeComponent();
        }
        public string ViewModel { get; set; }
        public void ShowViewModel()
        {
            inputName.Text = ViewModel;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
