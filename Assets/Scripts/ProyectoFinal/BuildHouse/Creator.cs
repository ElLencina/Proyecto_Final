using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HouseFactory
{
    public abstract class Creator
    {
        public abstract IHouse FactoryMethod(int i, int j, int length, string orientation, Transform transform);

        public GameObject Operation(int i, int j, int length, string orientation, Transform transform)
        {
            var product = FactoryMethod(i, j, length, orientation, transform);
            return product.Create(i, j, length, orientation, transform);
        }
     
    }
}
