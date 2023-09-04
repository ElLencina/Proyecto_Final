using HouseFactory;
using UnityEngine;

namespace CreateHouse.View
{
    public interface IViewBuildHouse
    {
        void BuildRow(int[,] arrayWall, string part, GameObject house);
        void BuildCol(int[,] arrayWall, string part, GameObject house);
        GameObject CreateObject(Creator CreatorObject, int i, int j, int length, string orientation, Transform transform);
    }
}