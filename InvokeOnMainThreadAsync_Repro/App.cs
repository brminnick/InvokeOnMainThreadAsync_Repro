using System.Threading.Tasks;
using Xamarin.Forms;

namespace InvokeOnMainThreadAsync_Repro
{
    public class App : Application
    {
        public App() => MainPage = new MainPage();
    }

    class MainPage : ContentPage
    {
        public MainPage()
        {
            var animatedButton_Crash = new Button { Text = "Crash" };
            animatedButton_Crash.Clicked += AnimatedButtonCrash_Clicked;

            var animatedButton_NoCrash = new Button { Text = "No Crash" };
            animatedButton_NoCrash.Clicked += AnimatedButtonNoCrash_Clicked;

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    animatedButton_Crash,
                    animatedButton_NoCrash
                }
            };
        }

        async void AnimatedButtonCrash_Clicked(object sender, System.EventArgs e) => await AnimateButton_Crash((Button)sender);

        async void AnimatedButtonNoCrash_Clicked(object sender, System.EventArgs e) => await AnimateButton_NoCrash((Button)sender);

        Task AnimateButton_Crash(View view)
        {
            return Device.InvokeOnMainThreadAsync(async () =>
            {
                await view.RotateTo(320);
                await view.RotateTo(-320);
                await view.RotateTo(0);
            });
        }

        Task AnimateButton_NoCrash(View view)
        {
            var tcs = new TaskCompletionSource<object>();

            Device.BeginInvokeOnMainThread(async () =>
            {
                await view.RotateTo(320);
                await view.RotateTo(-320);
                await view.RotateTo(0);

                tcs.SetResult(null);
            });

            return tcs.Task;
        }
    }
}
