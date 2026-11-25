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

namespace MyFirstApp1
{
    public partial class SecondWindow : Window
    {
        // Конструктор, который принимает имя из главного окна
        public SecondWindow(string nameFromMain)
        {
            InitializeComponent();

            // Проверяем, ввели ли имя на главном окне
            if (string.IsNullOrWhiteSpace(nameFromMain))
            {
                object lblSecondWelcome = null;
                lblSecondWelcome = "Привет, незнакомец! Вы не ввели имя.";
            }
            else
            {
                object lblSecondWelcome = null;
                lblSecondWelcome = "Привет, " + nameFromMain + "!";
            }
        }

        // Кнопка "Вернуться назад"
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            // Показываем главное окно (которое мы назначили как Owner)
            Owner.Show();

            // Закрываем текущее (второе) окно
            this.Close();
        }
    }
}