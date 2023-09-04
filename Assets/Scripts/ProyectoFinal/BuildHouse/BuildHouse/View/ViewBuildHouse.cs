using HouseFactory;
using CreateHouse.Dictionary;
using CreateHouse.Presenter;
using System.Collections.Generic;
using UnityEngine;

namespace CreateHouse.View
{
    public class ViewBuildHouse : MonoBehaviour, IViewBuildHouse
    {
        private const int ROW = 256;
        private const int COL = 256;

        private IPresenterBuildHouse presenterBuildHouse;
        private IDictionaryPartHouse dictionaryPartHouse;

        // Start is called before the first frame update
        void Start()
        {
            presenterBuildHouse = new PresenterBuildHouse();
        }

        public void BuildRow(int[,] arrayWall,string part, GameObject house)
        {
            presenterBuildHouse = new PresenterBuildHouse();
            dictionaryPartHouse = new DictionaryPartHouse();


            List<int> positions = new List<int>();
            int row = 0;
            int col = 0;
            int length = 0;

            for (int i = 0; i < ROW; i++)
            {
                positions = presenterBuildHouse.TraverseRow(arrayWall, i);
     
                for (int k = 0; k < positions.Count; k += 3) 
                {
                    row = positions[k];
                    col = positions[k + 1];
                    length = positions[k + 2];

                    CreateObject(dictionaryPartHouse.GetPartHouse(part), row, col, length, "row", house.transform);
                }
            }
        }

        public void BuildCol(int[,] arrayWall, string part, GameObject house)
        {
            presenterBuildHouse = new PresenterBuildHouse();
            dictionaryPartHouse = new DictionaryPartHouse();

            List<int> positions = new List<int>();
            int row = 0;
            int col = 0;
            int length = 0;

            for (int j = 0; j < COL; j++)
            {
                positions = presenterBuildHouse.TraverseCol(arrayWall, j);

                for (int k = 0; k < positions.Count; k += 3)
                {
                    row = positions[k];
                    col = positions[k + 1];
                    length = positions[k + 2];

                    CreateObject(dictionaryPartHouse.GetPartHouse(part), row, col, length, "col", house.transform);
                }
            }
        }

        public GameObject CreateObject(Creator CreatorObject, int i, int j, int length, string orientation, Transform transform)
        {
            return CreatorObject.Operation(i, j, length, orientation, transform);
        }
        
    }
}
