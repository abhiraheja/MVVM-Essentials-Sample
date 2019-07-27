using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MVVM_Essentials_Lib;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Networking.Connectivity;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MVVM_Essentials_Sample.Views.BasicTasks
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BasicTasks : Page
    {
        public BasicTasks()
        {
            this.InitializeComponent();
            checkInternet();
        }


        private void checkInternet()
        {

            txtInternetStatus.Text = MVVM_Essentials_Lib.CheckInternetAccess.CheckInternet() ? "Working" : "Not Working";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                txtNameResult.Text = txtName.Text.ToShort(14);
            }
            catch (Exception ex)
            {

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MVVM_Essentials_Lib.AlertBox.ShowBox("Alert", "Message");
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UICommand yesCMD = new UICommand("Yes");
            UICommand noCMD = new UICommand("No");
            var result = await MVVM_Essentials_Lib.AlertBox.ShowBoxYesNo_Reply("Alert", "Message", yesCMD, noCMD);
            if (result == yesCMD)
            {
                AlertBox.ShowBox("Success", "You Pressed Yes");
            }
            else if (result == noCMD)
            {
                AlertBox.ShowBox("Success", "You Pressed No");
            }
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UICommand yesCMD = new UICommand("Yes");
            UICommand noCMD = new UICommand("No");
            UICommand cancelCMD = new UICommand("Cancel");

            var result = await MVVM_Essentials_Lib.AlertBox.ShowBoxYesNo_Reply("Alert", "Message", yesCMD, noCMD, cancelCMD);
            if (result == yesCMD)
            {
                AlertBox.ShowBox("Success", "You Pressed Yes");
            }
            else if (result == noCMD)
            {
                AlertBox.ShowBox("Success", "You Pressed No");
            }
            else if (result == cancelCMD)
            {
                AlertBox.ShowBox("Success", "You Pressed Cancel");
            }


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MVVM_Essentials_Lib.AlertBox.ShowToastNotification("Alert", "Message");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MVVM_Essentials_Lib.AlertBox.ShowBoxCustomOK("Alert", "Message", "Hello");
        }
    }
}
