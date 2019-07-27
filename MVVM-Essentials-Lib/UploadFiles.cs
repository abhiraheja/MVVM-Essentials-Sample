using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace MVVM_Essentials_Lib
{
    public class UploadFiles
    {
        /// <summary>
        /// Upload Photo with 250x250 of size...
        /// It will automatically reduse the size of the file...
        /// </summary>
        /// <param name="FileName">File name to create the photo</param>
        /// <returns>File</returns>
        public static async Task<StorageFile> UploadPhoto(string FileName)
        {
            try
            {
                var picker = new Windows.Storage.Pickers.FileOpenPicker();
                picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
                picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
                picker.FileTypeFilter.Add(".jpg");
                picker.FileTypeFilter.Add(".jpeg");
                picker.FileTypeFilter.Add(".png");
                picker.FileTypeFilter.Add(".gif");
                var file = await picker.PickSingleFileAsync();
                if (file != null)
                {
                    StorageFile images = file;
                    StorageFolder fldr = await ApplicationData.Current.LocalFolder.CreateFolderAsync(string.IsNullOrEmpty(FileName) ? "dumpPhotos" : FileName, CreationCollisionOption.OpenIfExists);
                    var sds = await images.CopyAsync(fldr, images.DisplayName + images.FileType, NameCollisionOption.GenerateUniqueName);
                    var cFile = await ImageConvert.RescaleImage(sds, fldr, 250, 250);
                    return cFile;
                }
            }
            catch
            {

            }
            return null;
        }
        /// <summary>
        /// Upload image with original size of file
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public static async Task<StorageFile> UploadPhotoFullSize(string FileName)
        {
            try
            {
                var picker = new Windows.Storage.Pickers.FileOpenPicker();
                picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
                picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
                picker.FileTypeFilter.Add(".jpg");
                picker.FileTypeFilter.Add(".jpeg");
                picker.FileTypeFilter.Add(".png");
                picker.FileTypeFilter.Add(".gif");
                var file = await picker.PickSingleFileAsync();
                if (file != null)
                {
                    StorageFile images = file;
                    StorageFolder fldr = await ApplicationData.Current.LocalFolder.CreateFolderAsync(string.IsNullOrEmpty(FileName) ? "dumpPhotos" : FileName, CreationCollisionOption.OpenIfExists);
                    var sds = await images.CopyAsync(fldr, images.DisplayName + images.FileType, NameCollisionOption.GenerateUniqueName);
                    //var cFile = await BasicSettings.ImageConvert.RescaleImage(sds, fldr, 250, 250);
                    return sds;
                }
            }
            catch
            {

            }
            return null;
        }

        /// <summary>
        /// Upload Image and define the size of file of file
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>

        public static async Task<StorageFile> UploadPhoto(string FileName, uint width, uint height)
        {
            try
            {
                var picker = new Windows.Storage.Pickers.FileOpenPicker();
                picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
                picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
                picker.FileTypeFilter.Add(".jpg");
                picker.FileTypeFilter.Add(".jpeg");
                picker.FileTypeFilter.Add(".png");
                picker.FileTypeFilter.Add(".gif");
                var file = await picker.PickSingleFileAsync();
                if (file != null)
                {
                    StorageFile images = file;
                    StorageFolder fldr = await ApplicationData.Current.LocalFolder.CreateFolderAsync(string.IsNullOrEmpty(FileName) ? "dumpPhotos" : FileName, CreationCollisionOption.OpenIfExists);
                    var sds = await images.CopyAsync(fldr, images.DisplayName + images.FileType, NameCollisionOption.GenerateUniqueName);
                    var cFile = await ImageConvert.RescaleImage(sds, fldr, width, height);
                    return cFile;
                }
            }
            catch
            {

            }
            return null;
        }

        /// <summary>
        /// Upload any file with define parameters
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="filterType">List of string (file extenssion)</param>
        /// <returns></returns>

        public static async Task<StorageFile> UploadFile(string FileName, List<string> filterType)
        {
            try
            {
                var picker = new Windows.Storage.Pickers.FileOpenPicker();
                picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
                picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
                if (filterType.Count > 0)
                    foreach (var item in filterType)
                        picker.FileTypeFilter.Add(item);
                else
                    picker.FileTypeFilter.Add("*");
                var file = await picker.PickSingleFileAsync();
                if (file != null)
                {
                    StorageFile images = file;
                    StorageFolder fldr = await ApplicationData.Current.LocalFolder.CreateFolderAsync(string.IsNullOrEmpty(FileName) ? "dumpFile" : FileName, CreationCollisionOption.OpenIfExists);
                    var sds = await images.CopyAsync(fldr, images.DisplayName + images.FileType, NameCollisionOption.GenerateUniqueName);                  
                    return sds;
                }
            }
            catch
            {

            }
            return null;
        }
    }
}
