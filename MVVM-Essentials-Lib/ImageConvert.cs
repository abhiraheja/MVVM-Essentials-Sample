using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.Graphics.Imaging;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;

namespace MVVM_Essentials_Lib
{
    public class ImageConvert
    {
        static byte[] ImageData = null;

        public static byte[] ImageToByte(string Path)
        {
            try
            {
                var pattern = "ms-appx:///";
                var ragex = new Regex(pattern);
                Path = ragex.Replace(Path, "", 1);
                try
                {
                    FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
                    BinaryReader br = br = new BinaryReader(fs);
                    ImageData = br.ReadBytes((int)fs.Length);
                }
                catch (Exception ex)
                {

                }
                return ImageData;
            }
            catch (Exception)
            {
                //AlertBox..ShowBox("Warning", "Something Wrong");
                return null;
            }

        }
        public static BitmapImage byteToImage(Byte[] bytes)
        {
            try
            {
                byte[] code = bytes;
                System.IO.MemoryStream ms = new MemoryStream(code);
                var bitmapImg = new Windows.UI.Xaml.Media.Imaging.BitmapImage();
                Windows.Storage.Streams.InMemoryRandomAccessStream imras = new Windows.Storage.Streams.InMemoryRandomAccessStream();
                Windows.Storage.Streams.DataWriter write = new Windows.Storage.Streams.DataWriter(imras.GetOutputStreamAt(0));
                write.WriteBytes(code);
                 write.StoreAsync();
                bitmapImg.SetSourceAsync(imras);
                return bitmapImg;
            }
            catch (Exception)
            {
                // AlertBoxDB.ShowBox("Warning", "Something Wrong");
                return null;
            }
        }

        public static BitmapImage pathToBitmap(string path)
        {
            if (!string.IsNullOrEmpty(path))
                return new BitmapImage(new Uri(path));
            return null;
        }

        public static string checkLogoNull(string path)
        {
            if (path == "")
                return path = "ms-appx:///Assets/Login/None.png";
            else
                return path;

        }

        public static async Task<StorageFile> RescaleImage(StorageFile sourceFile, StorageFolder fldr, uint width, uint height)
        {
            try
            {
                var imageStream = await sourceFile.OpenReadAsync();
                var decoder = await BitmapDecoder.CreateAsync(imageStream);
                StorageFile resizedImageFile = await fldr.CreateFileAsync(sourceFile.DisplayName + sourceFile.FileType, CreationCollisionOption.GenerateUniqueName);

                using (var resizedStream = await resizedImageFile.OpenAsync(FileAccessMode.ReadWrite))
                {
                    var encoder = await BitmapEncoder.CreateForTranscodingAsync(resizedStream, decoder);
                    encoder.BitmapTransform.InterpolationMode = BitmapInterpolationMode.Linear;
                    encoder.BitmapTransform.ScaledWidth = width;
                    encoder.BitmapTransform.ScaledHeight = height;
                    await encoder.FlushAsync();
                }
                return resizedImageFile;
            }
            catch
            {
                return sourceFile;
            }
        }

    }
}
