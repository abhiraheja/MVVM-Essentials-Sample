using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MVVM_Essentials_Sample.Views.UploadImage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UploadFiles : Page
    {
        public UploadFiles()
        {
            this.InitializeComponent();
        }

        private async void btnBrowseSmallPic(object sender, RoutedEventArgs e)
        {
            StorageFile imgFile = await MVVM_Essentials_Lib.UploadFiles.UploadPhoto("Photo 1");
            if (imgFile != null)
            {
                txtUploadFilePath.Text = imgFile.Path;
                img1.Source = new BitmapImage(new Uri(imgFile.Path));
            }
        }

        private async void btnBrowseFullPic(object sender, RoutedEventArgs e)
        {
            StorageFile imgFile = await MVVM_Essentials_Lib.UploadFiles.UploadPhotoFullSize("Photo 1");
            if (imgFile != null)
            {
                txtUploadFilePath2.Text = imgFile.Path;
                img2.Source = new BitmapImage(new Uri(imgFile.Path));
            }
        }

        private async void btnBrowseResize(object sender, RoutedEventArgs e)
        {
            StorageFile imgFile = await MVVM_Essentials_Lib.UploadFiles.UploadPhoto("Photo 1", 300, 300);
            if (imgFile != null)
            {
                txtUploadFilePath3.Text = imgFile.Path;
                img3.Source = new BitmapImage(new Uri(imgFile.Path));
            }
        }

        private async void btnBrowseUploadDocument(object sender, RoutedEventArgs e)
        {
            List<string> filter = new List<string>
            {
                ".txt","*"
            };
            StorageFile File = await MVVM_Essentials_Lib.UploadFiles.UploadFile("File 1", filter);
            if (File != null)
            {
                txtUploadFilePath4.Text = File.Path;
                txtUploadedFileName.Text = File.DisplayName;
            }
        }
    }
}
