
using UnityEngine;

namespace HouseFactory
{
    public class DoorCreator : Creator
    {
        public override IHouse FactoryMethod(int i, int j, int length, string orientation, Transform transform)
        {
            return new Door();
        }
    }
}