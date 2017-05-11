using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Mobile_Hunter.ViewModel;
using Mobile_Hunter.Model;
using Windows.ApplicationModel.Store;
using Windows.ApplicationModel.DataTransfer;
using Windows.ApplicationModel.Email;
using Windows.ApplicationModel.Store;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Mobile_Hunter
{

    public sealed partial class MainPage : Page
    {
        public static int x = 0;
        public MainPage()
        {
            this.InitializeComponent();
            Data MyData = new Data();
            MyData.Data_in();
            samsung.ItemsSource = MyData.myList;


            Data2 MyData2 = new Data2();
            MyData2.Data_in();
            htc.ItemsSource = MyData2.myList2;


            Data3 MyData3 = new Data3();
            MyData3.Data_in();
            nokia.ItemsSource = MyData3.myList3;

            Data4 MyData4 = new Data4();
            MyData4.Data_in();
            sony.ItemsSource = MyData4.myList4;
        }





        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BasicPage2));

        }

        private void samsung_ItemClick(object sender, ItemClickEventArgs e)
        {
            var V = e.ClickedItem as Samsung;
            // create key to send its ID to the next page to and then mark it to show the specific data 
            var key = V.ID;
            x = 1;
            this.Frame.Navigate(typeof(BasicPage2), key);

        }

        private void htc_ItemClick(object sender, ItemClickEventArgs e)
        {
            var m = e.ClickedItem as HTC;
            var key = m.ID;
            x = 2;
            this.Frame.Navigate(typeof(BasicPage2), key);
        }

        private void nokia_ItemClick(object sender, ItemClickEventArgs e)
        {
            var m = e.ClickedItem as NOKIA;
            var key = m.ID;
            x = 3;
            this.Frame.Navigate(typeof(BasicPage2), key);
        }

        private void sony_ItemClick(object sender, ItemClickEventArgs e)
        {
            var m = e.ClickedItem as SONY;
            var key = m.ID;
            x = 4;
            this.Frame.Navigate(typeof(BasicPage2), key);
        }

        private void ScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {

        }

       

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("http://www.mobihall.com/");

        }

        private void aboutp_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(about_page));
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(about_page));
        }


        //private void CompList_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    var V = e.ClickedItem as DataSource;
        //    // create key to send its ID to the next page to and then mark it to show the specific data 
        //    var key = V.Id;
        //    // navigate to the other page with the ID
        //    Frame.Navigate(typeof(BasicPage1), key);
        //}

        //private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    this.Frame.Navigate(typeof(BasicPage1));
        //}
    }
}
