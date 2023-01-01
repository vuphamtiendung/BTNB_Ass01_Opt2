using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BTNB_Ass01_Opt2
{
    internal class UserAction : ConcreateCreator
    {
        public ConcreateCreator instanceCreator;

        /// <summary>
        /// Singleton
        /// </summary>
        public static UserAction useraction;
        public UserAction() { }
        public static UserAction GetUserAction()
        {
            if(useraction == null)
            {
                useraction = new UserAction();
            }
            return useraction;
        }

        public void Perfom()
        {
            instanceCreator = new ConcreateCreator();

            INetwork square = instanceCreator.Create(NetworkType.SQUARE);
            square.InputShape();
            WriteLine();
            square.DisplayShape();
            WriteLine("-----------------------------");

            INetwork triangle = instanceCreator.Create(NetworkType.TRIANGLE);
            triangle.InputShape();
            WriteLine();
            triangle.DisplayShape();
            WriteLine("-----------------------------");

            INetwork circle = instanceCreator.Create(NetworkType.CIRCLE);
            circle.InputShape();
            WriteLine();
            circle.DisplayShape();
            WriteLine("-----------------------------");
        }
    }
}
