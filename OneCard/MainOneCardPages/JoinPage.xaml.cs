﻿using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace OneCard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class JoinPage : Page
    {
        public JoinPage()
        {
            this.InitializeComponent();

            //Customize the status bar
            CustomeStatusBar();
        }

        // show the StatusBar
        private void CustomeStatusBar()
        {
            // turn on SystemTray for mobile
            // don't forget to add a Reference to Windows Mobile Extensions For The UWP
            if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                var statusbar = Windows.UI.ViewManagement.StatusBar.GetForCurrentView();
                //await statusbar.ShowAsync();
                statusbar.BackgroundColor = Windows.UI.Colors.RoyalBlue;
                statusbar.BackgroundOpacity = 1;
                statusbar.ForegroundColor = Windows.UI.Colors.White;
            }
        }

        private void sign_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SignInPage));
        }

        private void join_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(privateUserJoinPage));
        }

        private void businessJoin_Button_click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(IdentifierPage));
        }
    }
}
