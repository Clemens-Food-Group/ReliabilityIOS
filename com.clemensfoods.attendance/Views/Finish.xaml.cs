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
            string StatusColor = Data[0].ReliabilityStatus_CurrentMonth;
            string StatusColorSpanish = Data[0].ReliabilityStatus_CurrentMonth == "Green" ? "Verde" : Data[0].ReliabilityStatus_CurrentMonth == "Yellow" ? "Amarillo" : "Rojo";
            string MessageText = $"Hello {TMName}! Hola {TMName}!@Your current reliability status for the month is {StatusColor}  @ Su estado de confiabilidad actual para el mes es  {StatusColorSpanish}".Replace("@", System.Environment.NewLine) ;
            MessageLabel.Text = MessageText;



            collectionView.ItemsSource = Data;

            EndButton.Focus();

        }
                
        void Finish_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}
