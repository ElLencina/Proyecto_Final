using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HouseFactory
{
    public class WindowCreator : Creator
    {
        public override IHouse FactoryMethod(int i, int j, int length, string orientation, Transform transform)
        {
            return new Window();
        }
    }
}