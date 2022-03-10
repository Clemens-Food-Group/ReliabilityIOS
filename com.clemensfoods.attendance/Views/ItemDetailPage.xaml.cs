using System.ComponentModel;
using Xamarin.Forms;
using com.clemensfoods.attendance.ViewModels;

namespace com.clemensfoods.attendance.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
