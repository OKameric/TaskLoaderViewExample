using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TaskLoaderViewExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenXamlPageButton_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new TaskPageXaml());
        }

        private void OpenCodePageButton_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new TaskPageCode());
        }
    }
}
