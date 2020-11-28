using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Threading;
using System.Threading.Tasks;

namespace TrainApp.ViewModels
{
    public class MainViewModel
    {
        private Page Main;

        private Page currentPage;

        private double setOpacity;

        public MainViewModel()
        {
            currentPage = Main;
            setOpacity = 1;
        }
    }
}
