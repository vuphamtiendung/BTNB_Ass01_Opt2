using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNB_Ass01_Opt2
{
    internal interface INetwork
    {
        void InputShape();
        double Perimeter(); // Chu vi
        double Acreage(); // diện tích
        void DisplayShape();
    }
}
