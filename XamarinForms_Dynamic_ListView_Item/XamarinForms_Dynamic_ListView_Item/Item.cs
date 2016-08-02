using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamarinForms_Dynamic_ListView_Item.Annotations;

namespace XamarinForms_Dynamic_ListView_Item
{
    public class Item : INotifyPropertyChanged
    {
        private string _myText;
        private string _myImage;
        private bool _isExtraControlsVisible;


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public string MyText
        {
            get { return _myText; }
            set
            {
                _myText = value;
                OnPropertyChanged();
            }
        }

        public string MyImage
        {
            get { return _myImage; }
            set
            {
                _myImage = value;
                OnPropertyChanged();
            }
        }

        public bool IsExtraControlsVisible
        {
            get { return _isExtraControlsVisible; }
            set
            {
                _isExtraControlsVisible = value;
                OnPropertyChanged();
            }
        }
    }
}