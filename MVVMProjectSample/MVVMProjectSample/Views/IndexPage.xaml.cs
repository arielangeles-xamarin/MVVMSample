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
    public partial class IndexPage : MasterDetailPage
    {
        public IndexPage()
        {
            InitializeComponent();
        }

        private async void ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

    }
}