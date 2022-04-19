using System;
using System.Collections.Generic;
using com.clemensfoods.attendance.Models;
using Xamarin.Forms;

namespace com.clemensfoods.attendance.Views
{
    public partial class Finish : ContentPage
    {
        public Finish(List<AttendanceModel> Data)
        {

            InitializeComponent();

            //List<AttendanceModel> Data = new Services.REST().RestService(EntryTimeCard);

            string TMName = Data[0].TM_Name.Trim();
            string MessageText = $"Hello {TMName}! Hola {TMName}!@Your current reliability status for the month is @ Su estado de confiabilidad actual para el mes es".Replace("@", System.Environment.NewLine) ;
            MessageLabel.Text = MessageText;

 
            ReliabilityColorBox.BackgroundColor = Data[0].ReliabilityStatus_CurrentMonth == "Green" ? Color.Green : Data[0].ReliabilityStatus_CurrentMonth == "Yellow" ? Color.Yellow : Color.Red;



            collectionView.ItemsSource = Data;

            EndButton.Focus();

        }
                
        void Finish_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}
