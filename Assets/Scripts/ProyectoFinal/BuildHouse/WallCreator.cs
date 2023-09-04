using UnityEngine;

namespace HouseFactory
{
    public class WallCreator : Creator
    {
        public override IHouse FactoryMethod(int i, int j, int length, string orientation, Transform transform)
        {
            return new Wall();
        }
    }
}