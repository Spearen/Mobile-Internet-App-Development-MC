using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           

        }



        
       

        private void btnLogin_Clicked(object sender, EventArgs e)
        {



            bool isUserEmpty = String.IsNullOrEmpty(entryUsername.Text);//checks if the text field is empty
            bool isPassEmpty = String.IsNullOrEmpty(entryPassword.Text);

            if ((isUserEmpty) || (isPassEmpty))
            {
                //stop user logging in
            }

            else
            {
                //go to new page
                Navigation.PushAsync(new Page1());
            }


        }
    }
}
