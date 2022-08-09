using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace recyclingApp.ViewModel
{
    public class AddViewModel : BaseViewModel
    {
        public AddViewModel()
        {
            MenuList = GetMenu();
        }

        public List<Pick> MenuList { get; set; }

        public ICommand BackCommand => new Command(() => Application.Current.MainPage.Navigation.PopModalAsync());

        private List<Pick> GetMenu()
        {
            return new List<Pick>
            {
                new Pick { Title = "Metals",    
                    Description = "1.Aluminium " +
                    "2.Brass and Bronze.A copper alloy with zinc or tin" +
                    "3.Cast Iron.Mostly iron with some carbon and silicon", 

                    Price = "per KG 13.99" },

                new Pick { Title = "Plastics",  
                    Description = "We take all sorts of plastics pack in one bag.", 
                    Price = "per KG 5.00" },

                new Pick { Title = "Botttles",  
                    Description = "Add details about recycling bottles. " +
                    "1.Drinking or wine glasses and plates" +
                    "2.Ceramics, Pyrex, or other heat resistant glass" +
                    "3.Light bulbs" +
                    "4.mirrors" +
                    "5.Computer monitors and phone screens", 
                    Price = "per kG 12.99" },

                new Pick { Title = "Papers",
                    Description = "We collect all sorts of papers most recomendable one are box." +
                    "Print paper and office paper" +
                    "Scrap paper",
                    Price = "per KG 6.90" }
            };
        }
    }
}