using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class ListElement
    {
        public double First;
        public double Second;

        public override string ToString()
        {
            return $"{First} - {Second}";
        }
    }
}
