using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPageFlyout : ContentPage
    {
        public ListView ListView;

        public AboutPageFlyout()
        {
            InitializeComponent();

            BindingContext = new AboutPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class AboutPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<AboutPageFlyoutMenuItem> MenuItems { get; set; }

            public AboutPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<AboutPageFlyoutMenuItem>(new[]
                {
                    new AboutPageFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new AboutPageFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new AboutPageFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new AboutPageFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new AboutPageFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}