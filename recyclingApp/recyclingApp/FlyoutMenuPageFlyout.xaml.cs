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

namespace recyclingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutMenuPageFlyout : ContentPage
    {
        public ListView ListView;

        public FlyoutMenuPageFlyout()
        {
            InitializeComponent();

            BindingContext = new FlyoutMenuPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class FlyoutMenuPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<FlyoutMenuPageFlyoutMenuItem> MenuItems { get; set; }

            public FlyoutMenuPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<FlyoutMenuPageFlyoutMenuItem>(new[]
                {
                    new FlyoutMenuPageFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new FlyoutMenuPageFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new FlyoutMenuPageFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new FlyoutMenuPageFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new FlyoutMenuPageFlyoutMenuItem { Id = 4, Title = "Page 5" },
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