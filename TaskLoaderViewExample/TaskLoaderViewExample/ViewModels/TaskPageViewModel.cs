using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Sharpnado.Presentation.Forms.ViewModels;
using TaskLoaderViewExample.Annotations;
using Xamarin.Forms;

namespace TaskLoaderViewExample.ViewModels
{
    public class TaskPageViewModel : INotifyPropertyChanged
    {
        private ViewModelLoader<string> _dummyViewModel;

        public ViewModelLoader<string> DummyViewModel
        {
            get => _dummyViewModel;
            set => SetProperty(ref _dummyViewModel, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName]string propertyName = "", Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            NotifyPropertyChanged(propertyName);
            return true;
        }

        public TaskPageViewModel()
        {
            DummyViewModel = new ViewModelLoader<string>();
            DummyViewModel.Load(LoadDummy);
        }

        private async Task<string> LoadDummy()
        {
            await Task.Delay(5000);
            System.Diagnostics.Debug.WriteLine("DONE");
            return "Done";
        }
    }



}
