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
    public partial class ToDoListPage : ContentPage
    {
        public ToDoListPage()
        {
            InitializeComponent();
            Update();
            ToDoList.RefreshCommand = new Command(() =>
            {
                Update();
                ToDoList.IsRefreshing = false;
            });
        }
        private void Update()
        {
            if (App.client.RoleId == 0)
            {
                ToDoList.ItemsSource = null;
                ToDoList.ItemsSource = App.Db.GetListSort();
            }
            else
            {
                ToDoList.ItemsSource = null;
                ToDoList.ItemsSource = App.Db.GetList();
            }
        }
        private void AddToDoItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddItemPage());
        }
    }
}