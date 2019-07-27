using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Essentials_Lib
{
    public class CreateInitials
    {
        public static string getInitial(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var result = value.Trim().Split(' ');
                if (result.Length > 1)
                {
                    string val = result[0].Substring(0, 1) + result[1].Substring(0, 1);
                    return val;
                }
                else if (result[0].Length == 1)
                {
                    return result[0].Substring(0, 1);
                }
                else
                {
                    return result[0].Substring(0, 2);
                }
            }
            else
                return "";
        }
    }
}
