using System;
using System.Collections.Generic;
using System.Text;
using Sharpnado.Presentation.Forms.CustomViews;
using TaskLoaderViewExample.ViewModels;
using Xamarin.Forms;

namespace TaskLoaderViewExample
{
    public class TaskPageCode : ContentPage
    {
        public TaskPageCode()
        {
            BindingContext = new TaskPageViewModel();


            var taskView = new TaskLoaderView();
            var stack = new StackLayout();
            var label = new Label();
            label.Text = "CODE UI";
            label.HorizontalOptions = LayoutOptions.CenterAndExpand;
            label.VerticalOptions = LayoutOptions.CenterAndExpand;
            stack.Children.Add(label);
            taskView.Content = stack;


            taskView.SetBinding(TaskLoaderView.ViewModelLoaderProperty, "DummyViewModel");

            Content = taskView;
        }
    }
}
