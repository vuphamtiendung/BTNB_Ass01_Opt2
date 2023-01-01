using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BTNB_Ass01_Opt2
{
    internal class Circle : INetwork
    {
        private double _radius;
        private const double pi = 3.14;
        public double Radius { get { return _radius; } set { _radius = value; } }

        public Circle()
        {
            _radius = 0;
        }
        public Circle(double radius)
        {
            _radius = radius;
        }

        public string InputInfo(string message)
        {
            WriteLine(message);
            return ReadLine();
        }
        public void InputShape()
        {
            _radius = Convert.ToDouble(InputInfo(DisplayConstant.OUTPUT_DIAMETER_CIRCLE));
        }

        public double Perimeter()
        {
            return _radius * 2 * pi;
        }

        public double Acreage()
        {
            return _radius * _radius * pi;
        }

        public void DisplayShape()
        {
            WriteLine(DisplayConstant.OUTPUT_DIAMETER_CIRCLE, _radius);
            WriteLine(DisplayConstant.OUTPUT_PERIMETER_CIRCLE, Perimeter());
            WriteLine(DisplayConstant.OUTPUT_ACREAGE_CIRCLE, Acreage());
        }
    }
}
