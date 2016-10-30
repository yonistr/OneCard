using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace OneCard.BusinessPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChosenCustomerPage : Page
    {
        private Customer SelectedCustomer { set; get; }
        private DetailedCustomer DetailedSelectedCustomer { set; get; }

        public ChosenCustomerPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            SelectedCustomer = e.Parameter as Customer;
            // get the full card from the server
            DetailedSelectedCustomer = DetailedCustomer.GenerateDetailedCustomerDemo(SelectedCustomer);



            //Register for hardware and software back request from the system
            SystemNavigationManager systemNavigationManager = SystemNavigationManager.GetForCurrentView();
            systemNavigationManager.BackRequested += OnBackRequested;
            systemNavigationManager.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
        }
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            SystemNavigationManager systemNavigationManager = SystemNavigationManager.GetForCurrentView();
            systemNavigationManager.BackRequested -= OnBackRequested;
            systemNavigationManager.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        private void OnBackRequested(object sender, BackRequestedEventArgs e)
        {
            // Mark event as handled so we don't get bounced out of the app.
            e.Handled = true;
            // Page above us will be our master view.
            // Make sure we are using the "drill out" animation in this transition.
            Frame.Navigate(typeof(AllCustomersPage), "Back", new EntranceNavigationTransitionInfo());
        }

        private void ShowSplitSubscriptionEdit(object sender, RoutedEventArgs e)
        {
            SubscriptionEditSplitView.IsPaneOpen = !SubscriptionEditSplitView.IsPaneOpen;

            // Set the current expiry date of the subsciption to the "Subscription Edit" panel calander date picker
            ExpiryDateDatePicker.Date = DetailedSelectedCustomer.subscriptionInfo.expiryDate;

            // Uncheck the checkboxs in "Subscription Edit" panel
            CancelTagsCheckBox.IsChecked = false;
            ResetLastUseCheckBox.IsChecked = false;


            this.Bindings.Update();
        }

        private async void ApproveCahngesClicked(object sender, RoutedEventArgs e)
        {
            // First get an approval from the customer to the changes the save changes

            DetailedSelectedCustomer.subscriptionInfo.description = DescriptionTextBox.Text;
            DetailedSelectedCustomer.subscriptionInfo.type = TypeTextBox.Text;
            if (ExpiryDateDatePicker.Date.HasValue)
                DetailedSelectedCustomer.subscriptionInfo.expiryDate = ExpiryDateDatePicker.Date.Value.DateTime;
            DetailedSelectedCustomer.subscriptionInfo.numOfTagsAllowed = AllowedTagsComboBox.SelectedIndex;
            if (CancelTagsCheckBox.IsChecked.Value)
                DetailedSelectedCustomer.subscriptionInfo.numOfTagsInUse = 0;
            if (ResetLastUseCheckBox.IsChecked.Value)
                DetailedSelectedCustomer.subscriptionInfo.lastUse = DateTime.MinValue;

            // Send changes to server - TODO

            MessageDialog dialog = new MessageDialog("Subscription was changed successfully!!");

            await dialog.ShowAsync();

            this.Bindings.Update();

            SubscriptionEditSplitView.IsPaneOpen = !SubscriptionEditSplitView.IsPaneOpen;

            return;
        }
    }
}
