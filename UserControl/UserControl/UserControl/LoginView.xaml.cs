using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UserControl
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentView
	{
		public LoginView ()
		{
			InitializeComponent ();
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    this.Padding = new Thickness(20, 40, 20, 20);
                    break;
                default:
                    this.Padding = new Thickness(20);
                    break;
            }
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(LoginView));
        public static readonly BindableProperty ButtonProperty = BindableProperty.Create(nameof(ButtonText), typeof(string), typeof(LoginView));

        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }

        public string ButtonText
        {
            get
            {
                return (string)GetValue(ButtonProperty);
            }
            set
            {
                SetValue(ButtonProperty, value);
            }
        }

    }
}