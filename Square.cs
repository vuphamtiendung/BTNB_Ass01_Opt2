using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BTNB_Ass01_Opt2
{
    internal class Square : INetwork
    {
        private double _edge;
        public double Edge { get { return _edge; } set { _edge = value; } }
        public Square()
        {
            _edge = 0;
        }
        public Square(float edge)
        {
            _edge = edge;
        }
        public string InputInfo(string message)
        {
            WriteLine(message);
            return ReadLine();
        }

        public void InputShape()
        {
            _edge = Convert.ToDouble(InputInfo(DisplayConstant.INPUT_EDGE_SQUARE));
        }

        public double Perimeter()
        {
            return _edge * 4;
        }
        public double Acreage()
        {
            return _edge * _edge;
        }

        public void DisplayShape()
        {
            WriteLine(DisplayConstant.OUTPUT_EDGE_SQUARE, _edge);
            WriteLine(DisplayConstant.OUTPUT_PERIMETER_SQUARE, Perimeter());
            WriteLine(DisplayConstant.OUTPUT_ACREAGE_SQUARE, Acreage());
        }
    }
}
