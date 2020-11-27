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
    public partial class HomePage : TabbedPage
    {
        public int tapCount = 0;
        public HomePage()
        {
            InitializeComponent();
            BarBackgroundColor = Color.DarkRed;
            BarTextColor = Color.White;
            BindingContext = new HomeViewModel();
            
        }

        private void OnFrameTapped(object sender, EventArgs e)
        {
            tapCount++;
            if(sender is Frame frame)
            {
                if (tapCount % 2 == 0)
                {
                    frame.BorderColor = Color.DarkRed;
                }
                else
                {
                    frame.BorderColor = Color.Black;
                }
            }
            
        }
    }
}