using Windows.UI.Xaml.Controls;
using Uwp = Windows.UI.Xaml;

namespace Xamarin_UwB.UWP
{
	public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

			Current = this;

			this.HiddenFrame = new Frame() {
				Visibility = Uwp.Visibility.Collapsed
			};


			//LoadApplication(new Xamarin_Prime.App());
		}

		public static MainPage Current;

		private Frame HiddenFrame = null;
    }
}
