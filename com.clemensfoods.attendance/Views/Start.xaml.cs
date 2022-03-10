using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace com.clemensfoods.attendance.Views
{
    public partial class Start : ContentPage
    {
        public Start()
        {
            InitializeComponent();
        }

        void Enter_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            

            var result = new Services.REST().RestService();

            //if (result != null)

                Navigation.PushAsync(new Finish());

            //else
            //{
            //    //error
            //}
           
        }
    }
}
