using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;
using Windows.UI.Popups;

namespace MVVM_Essentials_Lib
{
    public class AlertBox
    {
        public static async void ShowBox(string Title, string Message)
        {
            MessageDialog dialog = new MessageDialog(Message);
            dialog.Title = Title;
            dialog.Commands.Add(new UICommand { Label = "OK", Id = 1 });
            await dialog.ShowAsync();
        }
        public static async void ShowBoxYesNo(string Title, string Message, UICommand YesClick, UICommand NoClick)
        {
            MessageDialog dialog = new MessageDialog(Message);
            dialog.Title = Title;
            dialog.Commands.Add(YesClick);
            dialog.Commands.Add(NoClick);
            dialog.CancelCommandIndex = 1;
            dialog.DefaultCommandIndex = 1;
            await dialog.ShowAsync();
        }

        public async static Task<IUICommand> ShowBoxYesNo_Reply(string Title, string Message, UICommand YesClick, UICommand NoClick)
        {
            MessageDialog dialog = new MessageDialog(Message);
            dialog.Title = Title;
            dialog.Commands.Add(YesClick);
            dialog.Commands.Add(NoClick);
            dialog.CancelCommandIndex = 1;
            dialog.DefaultCommandIndex = 1;
            var res = await dialog.ShowAsync();
            return res;
        }

        public async static Task<IUICommand> ShowBoxYesNo_Reply(string Title, string Message, UICommand YesClick, UICommand NoClick, UICommand cancelClick)
        {
            MessageDialog dialog = new MessageDialog(Message);
            dialog.Title = Title;

            dialog.Commands.Add(YesClick);
            dialog.Commands.Add(NoClick);
            dialog.Commands.Add(cancelClick);
            dialog.CancelCommandIndex = 2;
            dialog.DefaultCommandIndex = 2;
            var res = await dialog.ShowAsync();
            return res;
        }
        public static async void ShowBoxCustomOK(string Title, string Message, string buttonName)
        {
            MessageDialog dialog = new MessageDialog(Message);
            dialog.Title = Title;
            dialog.Commands.Add(new UICommand { Label = buttonName, Id = 1 });
            await dialog.ShowAsync();
        }
        public static void ShowToastNotification(string title, string stringContent)
        {
            try
            {
                ToastNotifier ToastNotifier = ToastNotificationManager.CreateToastNotifier();
                Windows.Data.Xml.Dom.XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(Windows.UI.Notifications.ToastTemplateType.ToastText02);
                Windows.Data.Xml.Dom.XmlNodeList toastNodeList = toastXml.GetElementsByTagName("text");
                toastNodeList.Item(0).AppendChild(toastXml.CreateTextNode(title));
                toastNodeList.Item(1).AppendChild(toastXml.CreateTextNode(stringContent));
                Windows.Data.Xml.Dom.IXmlNode toastNode = toastXml.SelectSingleNode("/toast");
                Windows.Data.Xml.Dom.XmlElement audio = toastXml.CreateElement("audio");
                audio.SetAttribute("src", "ms-winsoundevent:Notification.SMS");
                ToastNotification toast = new ToastNotification(toastXml);
                toast.ExpirationTime = DateTime.Now.AddSeconds(2);
                ToastNotifier.Show(toast);
            }
            catch (Exception)
            {
                AlertBox.ShowBox("Error", "Something Wrong");
            }
        }
    }
}
