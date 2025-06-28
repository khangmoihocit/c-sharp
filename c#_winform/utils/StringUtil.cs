using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utils
{
    public class StringUtil
    {
        public static bool checkString(string value)
        {
            bool isCheck = false;
            if ((value != null && value.Equals("")))
            {
                isCheck = true;
            }
            return isCheck;
        }


    }
}
