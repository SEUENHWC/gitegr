using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp2
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
        private void InputButton_Click(object sender, RoutedEventArgs e)
        {
            string userInput = inputTextBox.Text;

            // Проверяем ввод на валидность (условие для имени)
            if (IsValidName(userInput))
            {
                MessageBox.Show("Вы ввели: " + userInput, "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                // Выводим сообщение об ошибке
                MessageBox.Show("Вы ввели неверное имя! Имя должно содержать только буквы и быть длиной от 1 до 50 символов.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool IsValidName(string name)
        {
            // Проверяем, что имя не пустое и его длина корректная
            if (string.IsNullOrWhiteSpace(name) || name.Length < 1 || name.Length > 50)
            {
                return false;
            }

            // Используем регулярное выражение для проверки наличия только букв
            return Regex.IsMatch(name, @"^[A-Za-zА-Яа-яЁё\s'-]+$");
        }
    }
    }

