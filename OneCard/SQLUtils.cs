using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCard
{
    class SQLUtils
    {
        public static bool isValidUser(string username)
        {
            if (username != "y" && username!="s")
                return false;
            return true;
        }

        public static bool isPasswordCorrect(string username, string password)
        {
            if ((username != "y" || password!= "1") && (username != "s" || password != "5"))
                return false;
            return true;
        }

        public static string getUserType(string username)
        {
            if (username == "y")
            {
                return "private";
            }
            else
            {
                return "business";
            }
        }
    }
}
