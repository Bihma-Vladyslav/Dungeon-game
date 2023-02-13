using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class RealFabrics
    {
        public class DungeonLvl1 : AbstractDungeonLvl
        {
            public string LevelLenght = "short";
            public override Ghost createGhost()
            {
                return new GhostLvl1();
            }
            public override FakeChest createFakeChest()
            {
                return new FakeChestLvl1();
            }

            public override Zombie createZombie()
            {
                return new ZombieLvl1();
            }
            public override void start()
            {
                z = createZombie();
                g = createGhost();
                f = createFakeChest();
            }

        }
        public class DungeonLvl2 : AbstractDungeonLvl
        {
            public string LevelLenght = "average";
            public override Ghost createGhost()
            {
                return new GhostLvl1();
            }
            public override FakeChest createFakeChest()
            {
                return new FakeChestLvl1();
            }

            public override Zombie createZombie()
            {
                return new ZombieLvl1();
            }
            public override void start()
            {
                z = createZombie();
                g = createGhost();
                f = createFakeChest();
            }
        }
        public class DungeonLvl3 : AbstractDungeonLvl
        {
            public string LevelLenght = "long";
            public override Ghost createGhost()
            {
                return new GhostLvl1();
            }
            public override FakeChest createFakeChest()
            {
                return new FakeChestLvl1();
            }

            public override Zombie createZombie()
            {
                return new ZombieLvl1();
            }
            public override void start()
            {
                z = createZombie();
                g = createGhost();
                f = createFakeChest();
            }

        }
    }
}
