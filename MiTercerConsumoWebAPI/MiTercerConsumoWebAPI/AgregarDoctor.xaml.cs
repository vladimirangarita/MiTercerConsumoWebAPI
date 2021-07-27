using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiTercerConsumoWebAPI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AgregarDoctor : ContentPage
	{
		public AgregarDoctor ()
		{
			InitializeComponent ();
		}

        private void BtnEliminar_Clicked(object sender, EventArgs e)
        {

        }
    }
}