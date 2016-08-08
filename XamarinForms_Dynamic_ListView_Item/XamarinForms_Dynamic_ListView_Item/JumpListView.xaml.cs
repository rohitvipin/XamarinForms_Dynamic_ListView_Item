using Xamarin.Forms;

namespace XamarinForms_Dynamic_ListView_Item
{
    public partial class JumpListView : ContentPage
    {
        public JumpListView()
        {
            InitializeComponent();
            BindingContext = new JumpListViewModel();
            Title = "Jump List";
        }
    }
}
