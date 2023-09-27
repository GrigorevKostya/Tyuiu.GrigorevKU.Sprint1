using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GrigorevKU.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            value = value.Replace(" ", "");
            char[] valuechar = value.ToCharArray();
            Array.Reverse(valuechar);
            string valuenew = string.Join(string.Empty, valuechar);
            if (value == valuenew)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
