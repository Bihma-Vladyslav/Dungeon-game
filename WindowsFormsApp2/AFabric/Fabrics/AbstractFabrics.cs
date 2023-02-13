using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class AbstractFabrics
    {
        public abstract class AbstractDungeonLvl
        {
            public Zombie z;
            public Ghost g;
            public FakeChest f;
            public string LevelLenght;
            public abstract Zombie createZombie();
            public abstract Ghost createGhost();
            public abstract FakeChest createFakeChest();
            public abstract void start();

        }
    }
}
