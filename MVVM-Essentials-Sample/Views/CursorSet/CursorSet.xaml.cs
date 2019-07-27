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

namespace MVVM_Essentials_Sample.Views.CursorSet
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CursorSet : Page
    {
        public CursorSet()
        {
            this.InitializeComponent();
        }

        private void TextBox_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            MVVM_Essentials_Lib.MousePointers.SetArrowCursor();
        }

        private void TextBox_PointerHandEntered(object sender, PointerRoutedEventArgs e)
        {
            MVVM_Essentials_Lib.MousePointers.SetHandCursor();
        }

        private void TextBox_PointerCrossEntered(object sender, PointerRoutedEventArgs e)
        {
            MVVM_Essentials_Lib.MousePointers.SetCrossCursor();
        }

        private void TextBox_PointerHelpEntered(object sender, PointerRoutedEventArgs e)
        {
            MVVM_Essentials_Lib.MousePointers.SetHelpCursor();
        }

        private void TextBox_PointerIBeamEntered(object sender, PointerRoutedEventArgs e)
        {
            MVVM_Essentials_Lib.MousePointers.SetIBeamCursor();
        }

        private void TextBox_PointerPersonEntered(object sender, PointerRoutedEventArgs e)
        {
            MVVM_Essentials_Lib.MousePointers.SetPersonCursor();
        }

        private void TextBox_PointerPinEntered(object sender, PointerRoutedEventArgs e)
        {
            MVVM_Essentials_Lib.MousePointers.SetPinCursor();
        }

        private void TextBox_PointerUniversalNoEntered(object sender, PointerRoutedEventArgs e)
        {
            MVVM_Essentials_Lib.MousePointers.SetUniversalNoCursor();
        }

        private void TextBox_PointerWaitEntered(object sender, PointerRoutedEventArgs e)
        {
            MVVM_Essentials_Lib.MousePointers.SetWaitCursor();
        }
    }
}
