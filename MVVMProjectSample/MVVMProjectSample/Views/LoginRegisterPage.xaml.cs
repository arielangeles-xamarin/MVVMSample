using MVVMProjectSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMProjectSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginRegisterPage : TabbedPage
    {
        public LoginRegisterPage()
        {
            InitializeComponent();
            BindingContext = new LoginRegisterViewModel();
        }

        private async void OnRegisterLabelTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Register first", "Register on the next tab", "Ok");
        }
    }
}