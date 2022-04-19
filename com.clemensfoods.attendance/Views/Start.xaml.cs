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
            ProcessEntry();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            EntryTimeCard.Text = "";
            EntryTimeCard.Focus();
        }

        private void EntryTimeCard_TextChanged(object sender, TextChangedEventArgs e)
        {
            ProcessEntry();
        }

        private void ProcessEntry()
        {
            //DisplayAlert("Title", "Text Changed", "OK");
            if (EntryTimeCard.Text.Length > 4)
            {
                var result = new Services.REST().RestService(EntryTimeCard);

                if (result.Count > 0)
                {
                    Navigation.PushAsync(new Finish(result));
                    
                }
                else
                {
                    DisplayAlert("No Data Found", "You do not have any event information. Please contact HR if you believe this is incorrect", "OK");
                    EntryTimeCard.Text = "";
                }
            }
        }
    }
}
