using PreparationMobile.Models;
using PreparationMobile.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PreparationMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LogUpBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new RegistrationPage());
        }

        private async void LogInBtn_Clicked(object sender, EventArgs e)
        {
            if(LoginEn.Text == "gg" && PassEn.Text =="gg")
            {
                var cl = new Client("admin", "admin", "gg", "gg", 1);
                App.client = cl;
                await Navigation.PushModalAsync(new ToDoListPage());
            }
            else
            {
                if (!await CheckLogin())
                    await DisplayAlert("Error", "Неправильный пароль или логин", "Ok");
            }
        }
        private async Task<bool> CheckLogin()
        {
            foreach(var item in App.Db.GetClients())
            {
                if(item.Login == LoginEn.Text)
                {
                    if(item.Pass == PassEn.Text)
                    {
                        App.client = item;
                        await Navigation.PushModalAsync(new ToDoListPage());
                        return true;
                    }
                }    
            }
            return false;
        }
    }
}
