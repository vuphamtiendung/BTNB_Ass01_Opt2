using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BTNB_Ass01_Opt2
{
    internal  static class DisplayConstant
    {
        public const string INPUT_SHAPE = "=================================== SHARPE INFOMATION =================================";

        #region input shape
        public const string INPUT_EDGE_SQUARE = "Please Input egde of the square";
        public const string INPUT_EDGE_1_TRIANGLE = "Input edge 1 of the triangle";
        public const string INPUT_EDGE_2_TRIANGLE = "Input edge 2 of the triangle";
        public const string INPUT_EDGE_3_TRIANGLE = "Input edge 3 of the triangle";
        public const string INPUT_EDGE_HEIGHT_TRIANGLE = "Input edge height of the triangle";
        public const string INPUT_DIAMETER_CIRCLE = "Input diameter of the circle";
        #endregion

        #region output square
        public const string OUTPUT_EDGE_SQUARE = "Edge of the square: {0}";    
        public const string OUTPUT_PERIMETER_SQUARE = "Perimeter of the square: {0}";
        public const string OUTPUT_ACREAGE_SQUARE = "Acreage of the square: {0}";
        #endregion

        #region output triangle
        public const string OUTPUT_EDGE_1_TRIANGLE = "Edge 1 of the triangle: {0}";
        public const string OUTPUT_EDGE_2_TRIANGLE = "Edge 2 of the triangle: {0}";
        public const string OUTPUT_EDGE_3_TRIANGLE = "Edge 3 of the triangle: {0}";
        public const string OUTPUT_EDGE_HEIGHT_TRIANGLE = "Edge height of the triangle: {0}";
        public const string OUTPUT_PERIMETER_TRIANGLE = "Perimeter of the triangle: {0}";
        public const string OUTPUT_ACREAGE_TRIANGLE = "Acreage of the triangle: {0}";
        #endregion

        #region output circle
        public const string OUTPUT_DIAMETER_CIRCLE = "Diameter of the circle: {0}";
        public const string OUTPUT_PERIMETER_CIRCLE = "Perimeter of the circle: {0}";
        public const string OUTPUT_ACREAGE_CIRCLE = "Acreage of the circle: {0}";
        #endregion

        public const string END_OF_PAGE_MESSAGE = "======================================= END OF PAGE MESSAGE =================================";
    }
}
