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
    public sealed partial class SignInPage : Page
    {
        public SignInPage()
        {
            this.InitializeComponent();
        }

        private void join_now_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(privateUserJoinPage));
        }

        private async void login_click(object sender, RoutedEventArgs e)
        {
            string username = userNameBox.Text;
            string password = passwordBox.Password;

            if (SQLUtils.isValidUser(username) == false)
            {
                MessageDialog dialog = new MessageDialog("No such username!!!");

                await dialog.ShowAsync();
                return;
            }
            if (SQLUtils.isPasswordCorrect(username,password) == false)
            {
                MessageDialog dialog = new MessageDialog("Wrong password!!!");

                await dialog.ShowAsync();
                return;
            }
            string userType = SQLUtils.getUserType(username);
            App.myUser = new PrivateUser(username, password);
            if (userType == "private")
            {
                this.Frame.Navigate(typeof(AllCardsPage));
            }
            else
            {
                this.Frame.Navigate(typeof(IdentifierPage));
            }
        }

        private void NavigateBackTo_JoinPage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(JoinPage));
        }
    }
}
