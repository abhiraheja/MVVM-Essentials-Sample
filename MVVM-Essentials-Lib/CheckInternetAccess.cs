using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.Connectivity;
using Windows.UI.Xaml.Controls;

namespace MVVM_Essentials_Lib
{
    public class CheckInternetAccess
    {
      
        public static bool CheckInternet()
        {
            try
            {
                var connectionProfile = NetworkInformation.GetInternetConnectionProfile();
                if (connectionProfile != null)
                {
                    bool HasInternetAccess = (connectionProfile != null && connectionProfile.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess);
                    return HasInternetAccess;
                }
            }
            catch(Exception ex)
            {

            }
            return false;
        }
    }
}
