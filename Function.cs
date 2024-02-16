using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Function
    {
        public string ReturnsSnowballIfZero(int num)
        {
            if (num == 0) return "Snowballed!";
            else return "No snow :(";
        }
    }
}
