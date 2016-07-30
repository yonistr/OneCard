using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
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

namespace OneCard.PrivateUserPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChosenCardPage : Page
    {
        private GeneralCard SelectedCard { set; get; }
        private FullCard FullSelectedCard { set; get; }

        public ChosenCardPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            SelectedCard = e.Parameter as GeneralCard;
            // get the full card from the server
            FullSelectedCard = FullCard.GenerateFullCardDemo(SelectedCard.name);

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
            Frame.Navigate(typeof(AllCardsPage), "Back", new EntranceNavigationTransitionInfo());
        }

        private void FavoriteLoaded(object sender, RoutedEventArgs e)
        {
            Image img = sender as Image;
            BitmapImage bitmapImage = new BitmapImage();

            if (SelectedCard.isFavourite)
                bitmapImage.UriSource = new Uri("ms-appx:///Assets/favorite_filled_sign.png");
            else
                bitmapImage.UriSource = new Uri("ms-appx:///Assets/favorite_outlined_sign.png");
            img.Source = bitmapImage;
        }

        private void FavoriteStatusChangeTapped(object sender, TappedRoutedEventArgs e)
        {
            Image img = sender as Image;
            BitmapImage bitmapImage = new BitmapImage();

            if (SelectedCard.isFavourite)
            {
                SelectedCard.isFavourite = false;
                FullSelectedCard.isFavourite = false;
                bitmapImage.UriSource = new Uri("ms-appx:///Assets/favorite_outlined_sign.png");
            }
            else
            {
                SelectedCard.isFavourite = true;
                FullSelectedCard.isFavourite = true;
                bitmapImage.UriSource = new Uri("ms-appx:///Assets/favorite_filled_sign.png");
            }
            img.Source = bitmapImage;

            //update data in server
        }

        private void DirectWriteClicked(object sender, RoutedEventArgs e)
        {
            //get id from server
            //nfc short write to smartphone
        }

        private void TagWriteClicked(object sender, RoutedEventArgs e)
        {
            //get id from server
            //nfc short write to nfc tag
        }

        private void AddLocationClicked(object sender, RoutedEventArgs e)
        {
            //add location for card
            //update data in server
        }
    }
}
