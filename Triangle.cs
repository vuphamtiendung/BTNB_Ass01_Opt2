using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BTNB_Ass01_Opt2
{
    internal class Triangle : INetwork
    {
        private double _edge_1;
        private double _edge_2;
        private double _edge_3;
        private double _edge_height;

        public double Edge_1 { get { return _edge_1; } set { _edge_1 = value; } }   
        public double Edge_2 { get { return _edge_2;} set { _edge_2 = value; } }
        public double Edge_3 { get { return _edge_3; } set { _edge_3 = value; } }
        public double Edge_Height { get { return _edge_height; } set { _edge_height = value; } } 

        public Triangle()
        {
            _edge_1 = 0;
            _edge_2 = 0;
            _edge_3 = 0;
            _edge_height = 0;
        }

        public Triangle(double edge_1, double edge_2, double edge_3, double edge_height)
        {
            _edge_1 = edge_1;
            _edge_2 = edge_2;
            _edge_2 = edge_3;
            _edge_3 = edge_3;
            _edge_height = edge_height;
        }

        public string InputInfo(string message)
        {
            WriteLine(message);
            return ReadLine();
        }

        public void InputShape()
        {
            _edge_1 = Convert.ToDouble(InputInfo(DisplayConstant.INPUT_EDGE_1_TRIANGLE));
            _edge_2 = Convert.ToDouble(InputInfo(DisplayConstant.INPUT_EDGE_2_TRIANGLE));
            _edge_3 = Convert.ToDouble(InputInfo(DisplayConstant.INPUT_EDGE_3_TRIANGLE));
            _edge_height = Convert.ToDouble(InputInfo(DisplayConstant.INPUT_EDGE_HEIGHT_TRIANGLE));
        }

        public double Perimeter()
        {
            return _edge_1 + _edge_2 + _edge_3;
        }

        public double Acreage()
        {
            return (_edge_3 * _edge_height) / 2;
        }

        public void DisplayShape()
        {
            WriteLine(DisplayConstant.OUTPUT_EDGE_1_TRIANGLE, _edge_1);
            WriteLine(DisplayConstant.OUTPUT_EDGE_2_TRIANGLE, _edge_2);
            WriteLine(DisplayConstant.OUTPUT_EDGE_3_TRIANGLE, _edge_3);
            WriteLine(DisplayConstant.OUTPUT_EDGE_HEIGHT_TRIANGLE, _edge_height);
            WriteLine(DisplayConstant.OUTPUT_PERIMETER_TRIANGLE, Perimeter());
            WriteLine(DisplayConstant.OUTPUT_ACREAGE_TRIANGLE, Acreage());
        }
    }
}
