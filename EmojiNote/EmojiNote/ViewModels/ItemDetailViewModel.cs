using EmojiNote.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EmojiNote.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item item;
        private string itemId;
        private string text;
        private string description;
        public string Id { get; set; }

        public ItemDetailViewModel()
        {
            DeleteItemCommand = new Command(DeleteItem);
        }

        public Command DeleteItemCommand { get; }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

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

        public async void LoadItemId(string itemId)
        {
            try
            {
                 item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
        
        public async void DeleteItem()
        {
            try
            {
                var a = await DataStore.DeleteItemAsync(item.Id);
                if (a)
                {
                   await Shell.Current.GoToAsync("..");
                }
                    
                

            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }

    }
}
