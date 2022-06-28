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
    public partial class AddItemPage : ContentPage
    {
        bool state;
        bool state1 = false;
        public AddItemPage()
        {
            InitializeComponent();
        }

        private async void SaveItem_Clicked(object sender, EventArgs e)
        {
            if (DesItem.Text != null)
                App.Db.SaveToDoItem(new ToDoItem(DesItem.Text, App.client.Login));
            else
            {
                await Navigation.PopModalAsync();
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}