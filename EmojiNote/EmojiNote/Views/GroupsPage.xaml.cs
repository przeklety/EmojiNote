using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmojiNote.ViewModels;
using System.Threading.Tasks;
using EmojiNote.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmojiNote.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Group group { get; set; }
        public Page1()
        {
            InitializeComponent();
            BindingContext = new GroupsViewModel();
        }
    }
}