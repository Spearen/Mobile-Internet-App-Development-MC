using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : TabbedPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

            ToolbarItem current = (ToolbarItem)sender;
            if(current.Text == "Add")
            {
                Navigation.PushAsync(new MainPage());
            }

        }







    }
}