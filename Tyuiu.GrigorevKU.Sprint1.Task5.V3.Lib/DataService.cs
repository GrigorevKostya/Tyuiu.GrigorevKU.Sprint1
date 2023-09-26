using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GrigorevKU.Sprint1.Task5.V3.Lib  
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            string g = Convert.ToString(k);
            string glast = g.Substring(g.Length - 3);
            string h = glast.Substring(0, glast.Length - 2);
            return Convert.ToInt32(h);
            
            
        }
    }
}
