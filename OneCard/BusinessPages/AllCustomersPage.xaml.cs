using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace OneCard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AllCustomersPage : Page
    {
        private Customer SelectedCustomer;

        public AllCustomersPage()
        {
            this.InitializeComponent();
            MyCustomers.Source = Customer.GenerateCustomersSample();
        }

        private void ShowSplitSettings(object sender, RoutedEventArgs e)
        {
            MySettings.BusinessSettingsSplitView.IsPaneOpen = !MySettings.BusinessSettingsSplitView.IsPaneOpen;
        }

        private void OnCustomerClick(object sender, ItemClickEventArgs e)
        {
            // The clicked Customer it is the new selectedCustomer
            SelectedCustomer = e.ClickedItem as Customer;
            // Go to the chosen card page and display the full card derived from the general one
            Frame.Navigate(typeof(BusinessPages.ChosenCustomerPage), SelectedCustomer, new DrillInNavigationTransitionInfo());
        }
    }
}
