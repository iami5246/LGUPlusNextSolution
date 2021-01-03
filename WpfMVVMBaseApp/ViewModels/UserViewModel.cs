using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfMVVMBaseApp.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        public RelayCommand<object> saveCommand { get; set; }
        public RelayCommand<object> changeCommand { get; set; }

        public UserViewModel()
        {
            saveCommand = new RelayCommand<object>(OnSaveData);
            changeCommand = new RelayCommand<object>(OnChangeData);
        }

        string userId = string.Empty; 
        public string UserId { 
            get { return userId; } 
            set { userId = value; OnNotifyPropertyChanged("UserId"); } 
        }


        string userName = string.Empty;
        public string UserName
        {
            get { return userName; }
            set { userName = value; OnNotifyPropertyChanged(); }
        }


        string userEmail= string.Empty;
        public string UserEmail
        {
            get { return userEmail; }
            set { userEmail = value; OnNotifyPropertyChanged(); }
        }


        public void OnSaveData(object param)
        {
            Debug.WriteLine($"전달 커맨드 파라메터:{param}");
            Debug.WriteLine($"변경데이터:{this.UserId},{this.UserName},{this.UserEmail}");
            MessageBox.Show("저장완료");
        }

        public void OnChangeData(object param)
        {
            Debug.WriteLine($"전달 커맨드 파라메터:{param}");
            this.UserId = "kms";
            this.UserEmail = "ms@msoftware.co.kr";
            this.UserName = "강민서";
            MessageBox.Show("변경완료");
        }

        

    }
}
