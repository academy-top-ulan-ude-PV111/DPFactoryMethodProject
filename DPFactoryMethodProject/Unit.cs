using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFactoryMethodProject
{
    abstract class Unit
    {
        public abstract void Info();
    }

    class Infantry : Unit
    {
        public override void Info()
        {
            Console.WriteLine("Infantry");
        }
    }

    class Cavalery : Unit
    {
        public override void Info()
        {
            Console.WriteLine("Cavalery");
        }
    }

    class Archer : Unit
    {
        public override void Info()
        {
            Console.WriteLine("Archer");
        }
    }

    class Elephant : Unit
    {
        public override void Info()
        {
            Console.WriteLine("Elephant");
        }
    }

    abstract class Factory
    {
        public abstract Unit UnitCreate();
    }

    class InfantryFactory : Factory
    {
        public override Unit UnitCreate()
        {
            return new Infantry();
        }
    }

    class ArcherFactory : Factory
    {
        public override Unit UnitCreate()
        {
            return new Archer();
        }
    }

    class CavaleryFactory : Factory
    {
        public override Unit UnitCreate()
        {
            return new Cavalery();
        }
    }
    class ElephantFactory : Factory
    {
        public override Unit UnitCreate()
        {
            return new Elephant();
        }
    }

}
