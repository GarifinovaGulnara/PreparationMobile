using PreparationMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PreparationMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void LogUpBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                bool state = false;
                try
                {
                    state = true;
                }
                catch
                {
                    throw new Exception("Введите коректные данные");
                }
                if(state)
                {
                    if (Name.Text == null || Surname.Text == null || LoginEn.Text == null || PassEn.Text == null)
                        throw new Exception("Введите коректные данные");
                    else
                    {
                        Client client = new Client(Surname.Text, Name.Text, LoginEn.Text, PassEn.Text, 0);
                        App.Db.SaveClient(client);
                        App.client = client;
                        await Navigation.PushModalAsync(new ToDoListPage());
                    }
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Не удалось зарегистрироваться " + ex.Message, "Ok");
            }
        }
    }
}