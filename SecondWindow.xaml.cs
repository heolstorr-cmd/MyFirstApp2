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
using System.Windows.Shapes;

namespace MyFirstApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// TEST
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnGreet_Click(object sender, RoutedEventArgs e)
        {

            string name = txtName.Text; // что ввели
            if (string.IsNullOrWhiteSpace(name))
            {
                lblWelcome.Text = "Введите имя!";
                return;
            }
            lblWelcome.Text = "Привет, " + name + "!";
        }
        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            SecondWindow secondwindow = new SecondWindow(name); // создать
            secondwindow.Owner = this;
            secondwindow.Show(); // показать второе окно
            this.Hide(); // спрятать главное
        }
    }
}
