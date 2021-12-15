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
    public partial class NotesPageFlyout : ContentPage
    {
        public ListView ListView;

        public NotesPageFlyout()
        {
            InitializeComponent();

            BindingContext = new NotesPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class NotesPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<NotesPageFlyoutMenuItem> MenuItems { get; set; }

            public NotesPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<NotesPageFlyoutMenuItem>(new[]
                {
                    new NotesPageFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new NotesPageFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new NotesPageFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new NotesPageFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new NotesPageFlyoutMenuItem { Id = 4, Title = "Page 5" },
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