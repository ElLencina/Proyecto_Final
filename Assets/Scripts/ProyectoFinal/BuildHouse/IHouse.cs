using UnityEngine;

namespace HouseFactory
{
    public interface IHouse
    {
        GameObject Create(int i, int j, int length, string orientation, Transform transform);
    }
}