using HouseFactory;
using System.Collections.Generic;

namespace CreateHouse.Dictionary
{
    public class DictionaryPartHouse : IDictionaryPartHouse
    {
        private Dictionary<string, Creator> partHouse;

        public DictionaryPartHouse()
        {
            partHouse = new Dictionary<string, Creator>()
            {
                {"Wall", new WallCreator()},
                {"Door", new DoorCreator()},
                {"Window", new WindowCreator()}
            };
        }

        public Creator GetPartHouse(string part)
        {
            return partHouse[part];
        }

    }
}