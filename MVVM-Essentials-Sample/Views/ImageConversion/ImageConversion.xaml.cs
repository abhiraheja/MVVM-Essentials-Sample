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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MVVM_Essentials_Sample.Views.ImageConversion
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ImageConversion : Page
    {
        public ImageConversion()
        {
            this.InitializeComponent();
        }

        private async void btnBrowse(object sender, RoutedEventArgs e)
        {
            StorageFile file = await MVVM_Essentials_Lib.UploadFiles.UploadPhoto("Photo1");
            if (file != null)
            {
                byte[] img = MVVM_Essentials_Lib.ImageConvert.ImageToByte(file.Path);
                txtByteArraySize.Text = img.Length.ToString();
                img2.Source = MVVM_Essentials_Lib.ImageConvert.byteToImage(img);
            }
        }
    }
}
