using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using WpfMVVMBaseApp.ViewModels;

namespace WpfMVVMBaseApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

    

        public MainWindow()
        {
         

            InitializeComponent();
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UserViewModel vm = new UserViewModel();
            vm.UserId = "Eddy";
            vm.UserName = "강창훈";
            vm.UserEmail = "eddy@msoftware.co.kr";

            this.DataContext = vm;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var user = this.DataContext as UserViewModel;
            Debug.WriteLine($"변경데이터:{user.UserId},{user.UserName},{user.UserEmail}");

        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new UserViewModel() { UserId="kms",UserEmail="ms@msoftware.co.kr",UserName="강민서" };
        }


    

   
    }
}
