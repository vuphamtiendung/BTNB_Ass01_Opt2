using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BTNB_Ass01_Opt2
{
    internal class ConcreateCreator : NetworkFactory
    {
        /// <summary>
        /// Override method to create object
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public override INetwork Create(NetworkType type)
        {
            switch (type)
            {
                case NetworkType.SQUARE:
                    {
                        return new Square();
                    }
                case NetworkType.CIRCLE:
                    {
                        return new Circle();
                    }
                case NetworkType.TRIANGLE:
                    {
                        return new Triangle();
                    }
                default:
                    {
                        throw new ArgumentException("Invalid type", "type");
                    }
            }
        }
    }
}
