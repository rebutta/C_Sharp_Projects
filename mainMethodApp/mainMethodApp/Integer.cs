using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMethodApp
{
    public class Integer
    {
        public int methodOne(int x)
        {
            return 5 + x;
        }

        public double methodOne(double g)
        {
            return 5.5 + g; 
        }

        public string methodOne(string z)
        {
            Convert.ToInt32(z);
            return 8 + z;
        }
    }
}
