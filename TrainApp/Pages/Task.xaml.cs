﻿using System;
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
using TrainApp.scripts;

namespace TrainApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task.xaml
    /// </summary>
    public partial class Task : Page
    {
        public Task()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {


            TaskObj task = new TaskObj(fdeadline.Text, date.Text, autor.Text, priority.Text);
            MessageBox.Show(task.autor);



        }
    }
}
