using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindboxTest
{
    public class Util
    {
        public static void Swap<T>(ref T var1, ref T var2)
        {
            T temp = var1;
            var1 = var2;
            var2 = temp;
        }
    }
}
