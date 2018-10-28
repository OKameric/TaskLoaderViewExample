using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskLoaderViewExample.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskLoaderViewExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TaskPageXaml : ContentPage
	{
		public TaskPageXaml ()
		{
			InitializeComponent ();

		    BindingContext = new TaskPageViewModel();
		}
	}
}