using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        DispatcherTimer t = new DispatcherTimer();


        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.


        }
        private string PasswordGen(Random rnd, int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890abcdefghijklmnopqrstuvwxyz.-";
            StringBuilder pass = new StringBuilder();

            while (length != 0)
            {
                pass.Append(chars[(int)(rnd.NextDouble() * chars.Length)]);
                length--;
            }
            return pass.ToString();


        }


        private void generatenum(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            t.Interval = new TimeSpan(0, 0, 0, 5);
            t.Tick += T_Tick;
            t.Start();
            OneTime.Text = PasswordGen(rnd, 8);
        }

        private void T_Tick(object sender, object e)
        {
            OneTime.Text = String.Empty;
            t.Stop();

        }

    }
        
    }

