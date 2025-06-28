using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utils
{
    public class NumberUtil
    {
        public static bool checkNumber(string value)
        {
            try
            {
                long number = long.Parse(value);
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
