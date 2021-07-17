using EmojiNote.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace EmojiNote.Views
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