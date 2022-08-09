using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace recyclingApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Picks = GetPicks();

    
        }

        public List<Pick> Picks { get; set; }

        public ICommand AddCommand => new Command(() => Application.Current.MainPage.Navigation.PushModalAsync(new RecyclePage()));

        private List<Pick> GetPicks()
        {
            return new List<Pick>
            {
                new Pick { Title = "BOTTLES", Image = "IMG01.png",
                    Description = "Bottles can be recycle ......to be added with correct details " },
                new Pick { Title = "CANS", Image = "IMG03.png",
                    Description = "Cans can be recycle ......to be added with correct details " }
            };
        }
    }

    public class Pick
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }


    public class BaseViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }

}