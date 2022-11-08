using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFactoryMethodProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factory;
            List<Factory> factories = new List<Factory>();
            factories.Add(new InfantryFactory());
            factories.Add(new ArcherFactory());
            factories.Add(new CavaleryFactory());
            factories.Add(new ElephantFactory());

            Random random = new Random();

            List<Unit> units = new List<Unit>();

            for(int i = 0; i < 10; i++)
            {
                factory = factories[random.Next(0, factories.Count)];
                units.Add(factory.UnitCreate());
            }

            foreach (Unit unit in units)
                unit.Info();
        }
    }
}
