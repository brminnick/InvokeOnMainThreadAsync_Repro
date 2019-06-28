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
            var animatedButton_NoCrash = new Button { Text = "No Crash" };
            animatedButton_NoCrash.Clicked += AnimatedButtonNoCrash_Clicked;

            var animatedButton_Crash1 = new Button { Text = "Crash1" };
            animatedButton_Crash1.Clicked += AnimatedButtonCrash1_Clicked;

            var animatedButton_Crash2 = new Button { Text = "Crash2" };
            animatedButton_Crash2.Clicked += AnimatedButtonCrash2_Clicked;

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    animatedButton_NoCrash,
                    animatedButton_Crash1,
                    animatedButton_Crash2
                }
            };
        }

        async void AnimatedButtonCrash1_Clicked(object sender, System.EventArgs e) => await AnimateButton_Crash1((Button)sender);

        async void AnimatedButtonCrash2_Clicked(object sender, System.EventArgs e) => await AnimateButton_Crash2((Button)sender);

        async void AnimatedButtonNoCrash_Clicked(object sender, System.EventArgs e) => await AnimateButton_NoCrash((Button)sender);

        Task AnimateButton_Crash1(View view) => Device.InvokeOnMainThreadAsync(async () => await RotateView(view).ConfigureAwait(false));

        Task AnimateButton_Crash2(View view) => Device.InvokeOnMainThreadAsync(() => RotateView(view));

        Task AnimateButton_NoCrash(View view)
        {
            var tcs = new TaskCompletionSource<object>();

            Device.BeginInvokeOnMainThread(async () =>
            {
                await RotateView(view).ConfigureAwait(false);

                tcs.SetResult(null);
            });

            return tcs.Task;
        }

        async Task RotateView(View view)
        {
            await view.RotateTo(320);
            await view.RotateTo(-320);
            await view.RotateTo(0);
        }
    }
}
