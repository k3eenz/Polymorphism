using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    public class CustomConverter
    {
        public void Converter(string input, out int result)
        {
            result = Convert.ToInt32(input);
        }
        public void Converter(string input, out double result)
        {
            result = Convert.ToDouble(input);
        }
        public void Converter(string input, out bool result)
        {
            result = Convert.ToBoolean(input);
        }
    }
}
