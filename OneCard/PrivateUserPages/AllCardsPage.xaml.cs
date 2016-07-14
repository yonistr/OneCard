using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class AllCardsPage : Page
    {
        private GeneralCard SelectedCard;

        public AllCardsPage()
        {
            this.InitializeComponent();
            //App.myUser = GenerateUser();
            MyCards.Source = GeneralCard.GenerateCategory();
        }

        private void ShowSplitSettings(object sender, RoutedEventArgs e)
        {
            MySettings.privateUserSettingsSplitView.IsPaneOpen = !MySettings.privateUserSettingsSplitView.IsPaneOpen;
        }

        private void OnCardClick(object sender, ItemClickEventArgs e)
        {
            // The clicked card it is the new selectedCard
            SelectedCard = e.ClickedItem as GeneralCard;
            // Go to the chosen card page and display the full card derived from the general one
            Frame.Navigate(typeof(PrivateUserPages.ChosenCardPage), SelectedCard, new DrillInNavigationTransitionInfo());

        }


    }
}
