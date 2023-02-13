namespace WindowsFormsApp2
{
        // abstract mobs
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
        //abstractFactory
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
        // realfabric,  dungeon  levels, закінчив на цьому моменті
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
   
        public class GhostLvl1:Ghost
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
