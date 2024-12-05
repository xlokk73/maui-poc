#if __ANDROID__
using Com.Example.Helloandroidlibrary;
#endif

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {

#if __ANDROID__
        HelloAndroid helloAndroid = new HelloAndroid();
        string message = helloAndroid.SayHello();
        CounterBtn.Text = message;
#else
        CounterBtn.Text = "Not Supported";
#endif

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

