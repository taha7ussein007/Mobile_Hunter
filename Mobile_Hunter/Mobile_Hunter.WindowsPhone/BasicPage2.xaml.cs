using Mobile_Hunter.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Mobile_Hunter.Model;
using Windows.UI.Xaml.Media.Imaging;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Mobile_Hunter
{
    public sealed partial class BasicPage2 : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        Data NW = new Data();
        Data2 n = new Data2();
        Data3 n2 = new Data3();
        Data4 n3 = new Data4();

        public BasicPage2()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;

            NW.Data_in();
            n.Data_in();
            n2.Data_in();
            n3.Data_in();
        }




        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
            if (MainPage.x == 1)
            {
                if (e.Parameter != null && !string.IsNullOrWhiteSpace(e.Parameter.ToString()))
                {
                    int key = int.Parse(e.Parameter.ToString());
                    pPrice.Text = NW.myList[key].Price.ToString();
                    pName.Text = NW.myList[key].PName;
                    specs.Text = NW.myList[key].Specs;

                    BitmapImage bi = new BitmapImage(new Uri("ms-appx:///" + NW.myList[key].PImage));
                    pic.Source = bi;
                }
            }
            else if (MainPage.x == 2)
            {
                if (e.Parameter != null && !string.IsNullOrWhiteSpace(e.Parameter.ToString()))
                {
                    int key = int.Parse(e.Parameter.ToString());
                    pPrice.Text = n.myList2[key].Price.ToString();
                    pName.Text = n.myList2[key].PName;
                    specs.Text = n.myList2[key].Specs;

                    BitmapImage bi = new BitmapImage(new Uri("ms-appx:///" + n.myList2[key].PImage));
                    pic.Source = bi;
                }

            }

            else if (MainPage.x == 3)
            {
                if (e.Parameter != null && !string.IsNullOrWhiteSpace(e.Parameter.ToString()))
                {
                    int key = int.Parse(e.Parameter.ToString());
                    pPrice.Text = n2.myList3[key].Price.ToString();
                    pName.Text = n2.myList3[key].PName;
                    specs.Text = n2.myList3[key].Specs;

                    BitmapImage bi = new BitmapImage(new Uri("ms-appx:///" + n2.myList3[key].PImage));
                    pic.Source = bi;
                }

            }


            else if (MainPage.x == 4)
            {
                if (e.Parameter != null && !string.IsNullOrWhiteSpace(e.Parameter.ToString()))
                {
                    int key = int.Parse(e.Parameter.ToString());
                    pPrice.Text = n3.myList4[key].Price.ToString();
                    pName.Text = n3.myList4[key].PName;
                    specs.Text = n3.myList4[key].Specs;

                    BitmapImage bi = new BitmapImage(new Uri("ms-appx:///" + n3.myList4[key].PImage));
                    pic.Source = bi;
                }

            }
        }


        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.



        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var uri = new Uri("http://www.mobihall.com/");
            IAsyncOperation<bool> x = Windows.System.Launcher.LaunchUriAsync(uri);
        }


    }
}


