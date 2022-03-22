using Notes.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

using Notes.Models;
namespace Notes.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        private readonly ItemDetailViewModel viewModel;
        public Note NewNote { get; set; }


        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }
        
        
        
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}