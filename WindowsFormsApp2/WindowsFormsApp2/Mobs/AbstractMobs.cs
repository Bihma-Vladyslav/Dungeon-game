using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class AbstractMobs
    {
        abstract public class Zombie
        {
            public string height;
            public void move()
            {

            }
            public void animationOfMoving()
            {

            }

        }
        abstract public class Ghost
        {
            public string color;
            public void move()
            {

            }
            public void animationOfMoving()
            {

            }
        }
        abstract public class FakeChest
        {
            public string property;
            public void move()
            {

            }
            public void animationOfMoving()
            {

            }
        }
    }
}
