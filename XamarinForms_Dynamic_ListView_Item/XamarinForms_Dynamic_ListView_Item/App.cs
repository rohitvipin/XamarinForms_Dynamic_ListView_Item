using Xamarin.Forms;

namespace XamarinForms_Dynamic_ListView_Item
{
    public class App : Application
    {
        public App()
        {
            MainPage = new DynamicListView();
            //MainPage = new JumpListView();
        }
    }
}
