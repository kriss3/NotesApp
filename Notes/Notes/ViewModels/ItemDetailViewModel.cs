using Notes.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Notes.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string text;
        private string description;
        public string Id { get; set; }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string DisplayMessage { get; set; }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public Command CancelItemCommand { get; }
        public Command SaveItemCommand { get; set; }
        public ItemDetailViewModel()
        {
            CancelItemCommand = new Command(OnCancelItem);
            SaveItemCommand = new Command(OnSaveItem);
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }

        private void OnCancelItem(object obj) 
        {
            DisplayMessage = "Cancel option was selected.\nData not saved.";
            Application.Current.MainPage.DisplayAlert("Canel Selection", DisplayMessage, "Cancel");
        }
    
        private void OnSaveItem(object obj) 
        {
            DisplayMessage = "Save was clicked.";
            Application.Current.MainPage.DisplayAlert("Save Selection", DisplayMessage, "Btn 1", "Btn 2");
        }
    }
}
