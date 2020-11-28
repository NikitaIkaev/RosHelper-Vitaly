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
using TrainApp.Pages;
using Task = TrainApp.Pages.Task;

namespace TrainApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Страницы
        Main main = new Main();
        Chat chat = new Chat();
        Task task = new Task();
        profile Profile = new profile();

        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Content = main;
            header.Text = "Домашняя страница";
        }
     
        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void HideBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            string name = ((ListViewItem)sender).Name;
            switch (name)
            {
                case ("home"):
                    mainFrame.Content = main;
                    header.Text = "Домашняя страница";
                    break;
                case ("chatonetoone"):                  
                    mainFrame.Content = chat;
                    header.Text = "Переписка";
                    break;
                case ("tasks"):
                    mainFrame.Content = task;
                    header.Text = "Задачи";
                    break;
                case ("user"):
                    mainFrame.Content = Profile;
                    header.Text = "Профиль";
                    break;
                default:
                    break;
            }
        
            
        }

        // Класс данных для создания списка 
        //public class user
        //{
        //    public string photo { get; set; }
        //    public string Name { get; set; }
        //    public string Second_name { get; set; }
        //    public string priority { get; set; }
        //}

        //void LoadUsers()
        //{
        //    DataTable dt_users = Select("SELECT * FROM [dbo].[users]"); // данные из БД  
        //    for (int i = 0; i < dt_users.Rows.Count; i++) // перебираем данные  
        //    {
        //        user dataUser = new user() // создаём экземпляр класса        
        //        {
        //            photo = dt_users.Rows[i][2].ToString(), // указываем изображение из таблицы    
        //            login = dt_users.Rows[i][0].ToString(), // указываем логин         
        //            password = dt_users.Rows[i][1].ToString() // казываем пароль     
        //        };
        //        listUsers.Items.Add(dataUser); // выводим строку в список 
        //    }
        //}
        //public MainWindow()
        //{
            //InitializeComponent();
            //LoadUsers(); // вызываем функции загрузки
        //}
        //   public DataTable Select(string selectSQL) // функция подкючения к базе данных и ее дальнейшей обработки_

    }
}
