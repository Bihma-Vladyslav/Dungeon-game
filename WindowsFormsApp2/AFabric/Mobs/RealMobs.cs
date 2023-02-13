using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class RealMobs
    {
        public class ZombieLvl1 : Zombie
        {
            public ZombieLvl1()
            {
                height = "average";
            }

        }

        public class ZombieLvl2 : Zombie
        {
            public ZombieLvl2()
            {
                height = "tall";
            }
        }

        public class ZombieLvl3 : Zombie
        {
            public ZombieLvl3()
            {
                height = "short";
            }
        }

        public class GhostLvl1 : Ghost
        {
            public GhostLvl1()
            {
                color = "white transparent";
            }
        }
        public class GhostLvl2 : Ghost
        {
            public GhostLvl2()
            {
                color = "blue transparent";
            }
        }
        public class GhostLvl3 : Ghost
        {
            public GhostLvl3()
            {
                color = "green transparent";
            }
        }

        public class FakeChestLvl1 : FakeChest
        {
            public FakeChestLvl1()
            {
                property = "with tentacles";
            }
        }
        public class FakeChestLvl2 : FakeChest
        {
            public FakeChestLvl2()
            {
                property = "with sharp teeth";
            }
        }
        public class FakeChestLvl3 : FakeChest
        {
            public FakeChestLvl3()
            {
                property = "with a weapon in hand";
            }
        }
    }
}
