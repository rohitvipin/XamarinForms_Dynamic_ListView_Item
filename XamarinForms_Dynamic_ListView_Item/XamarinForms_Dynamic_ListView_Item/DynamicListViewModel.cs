using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using XamarinForms_Dynamic_ListView_Item.Annotations;

namespace XamarinForms_Dynamic_ListView_Item
{
    public class DynamicListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Item> _allItems;
        private Item _mySelectedItem;

        public DynamicListViewModel()
        {
            AllItems = new ObservableCollection<Item>(new List<Item> { new Item { MyText = "1" }, new Item { MyText = "2" }, new Item { MyText = "3" } });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public ObservableCollection<Item> AllItems
        {
            get { return _allItems; }
            set
            {
                _allItems = value;
                OnPropertyChanged();
            }
        }

        public Item MySelectedItem
        {
            get { return _mySelectedItem; }
            set
            {
                _mySelectedItem = value;
                OnPropertyChanged();

                foreach (var item in AllItems)
                {
                    item.IsExtraControlsVisible = false;
                }
                var selectedItem = AllItems.FirstOrDefault(x => x.Equals(value));
                if (selectedItem != null)
                {
                    selectedItem.IsExtraControlsVisible = true;
                }
            }
        }
    }
}