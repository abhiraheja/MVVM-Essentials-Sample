using MVVM_Essentials_Sample.ViewModel.NavigationPage;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MVVM_Essentials_Sample.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MenuPage : Page
    {
        NavigationViewModel vm;
        public MenuPage()
        {
            this.InitializeComponent();
            vm = new NavigationViewModel();
            this.DataContext = vm;
        }

        private void NvSample_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavigationViewItem navi = (NavigationViewItem)args.SelectedItem;
            if (navi != null)
            {
                switch (navi.Tag.ToString())
                {
                    case "upload":
                        contentFrame.Navigate(typeof(UploadImage.UploadFiles));
                        vm.Title = "Upload Files";
                        vm.SubTitle = "Upload Files and Images";
                        break;
                }
            }
        }

        private void NvSample_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
