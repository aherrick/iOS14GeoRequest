namespace iOS14GeoRequest
{
    public class RootTabPage : Xamarin.Forms.TabbedPage
    {
        public RootTabPage()
        {
            Title = "App";

            Children.Add(new MainPage());
        }
    }
}