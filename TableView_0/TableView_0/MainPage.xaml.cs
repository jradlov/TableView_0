using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TableView_0
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void EntryCell_Completed(object sender, EventArgs e)
        {
            string str = entry1.Text;
            DisplayAlert("Entry Cell", str, "Ok");
        }

        private void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Switch Cell", e.Value.ToString(), "Ok");
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            DisplayAlert("Date Selected", e.NewDate.ToLongDateString(), "Ok");
        }
    }
}
