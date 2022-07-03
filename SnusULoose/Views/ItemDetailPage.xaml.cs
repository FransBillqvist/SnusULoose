using System.ComponentModel;
using Xamarin.Forms;
using SnusULoose.ViewModels;

namespace SnusULoose.Views
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
