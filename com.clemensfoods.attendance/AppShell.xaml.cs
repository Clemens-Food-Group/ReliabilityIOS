using System;
using System.Collections.Generic;
using com.clemensfoods.attendance.ViewModels;
using com.clemensfoods.attendance.Views;
using Xamarin.Forms;

namespace com.clemensfoods.attendance
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
