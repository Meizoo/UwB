using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UwB_UI
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class ViewMode : Page
	{
		public ViewMode()
		{
			InitializeComponent();

			Table table = new Table(
				(1, new List<DateTime>() { DateTime.Now }),
				(2, new List<DateTime>() { DateTime.Now }),
				(3, new List<DateTime>() { DateTime.Now })
			);

			this.DatabaseView.Items.Add(table);
		}
	}
}
