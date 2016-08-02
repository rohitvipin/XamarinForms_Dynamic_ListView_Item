using Xamarin.Forms;

namespace XamarinForms_Dynamic_ListView_Item
{
    public partial class DynamicListView : ContentPage
    {
        public DynamicListView()
        {
            InitializeComponent();
            BindingContext = new DynamicListViewModel();
            Title = "Dynamic List";
        }
    }
}
