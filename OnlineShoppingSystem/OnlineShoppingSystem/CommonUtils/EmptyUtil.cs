using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingSystem.CommonUtils
{
    public class EmptyUtil
    {
        public static bool CheckEmpty(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return true;
            }

            return false;
        }
    }
}