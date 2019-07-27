using MVVM_Essentials_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Essentials_Sample.ViewModel.NavigationPage
{
    public class NavigationViewModel : BaseViewModel
    {
        private string _Title;
        public string Title
        {
            get { return _Title; }
            set { Set(ref _Title, value); }
        }

        private string _SubTitle;
        public string SubTitle
        {
            get { return _SubTitle; }
            set { Set(ref _SubTitle, value); }
        }

        private string _Footer;
        public string Footer
        {
            get { return _Footer; }
            set { Set(ref _Footer, value); }
        }
    }
}
