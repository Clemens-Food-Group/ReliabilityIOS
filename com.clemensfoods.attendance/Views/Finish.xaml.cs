using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace com.clemensfoods.attendance.Views
{
    public partial class Finish : ContentPage
    {
        public Finish()
        {
            InitializeComponent();
            collectionView.ItemsSource = new Services.REST().RestService();
        }
        void Finish_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            
            Navigation.PopToRootAsync();

        }
    }
}
