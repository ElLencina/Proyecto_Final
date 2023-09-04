using UnityEngine;

namespace HouseFactory
{
    public class Wall : IHouse
    {
        public GameObject Create(int i, int j, int length, string orientation, Transform transform)
        {
            Vector3 position;
            Quaternion rotation = Quaternion.Euler(0, 90, 0); ;

            float pos = (float)(length / 2);

            if (length % 2 == 0)
                pos -= 0.5f;
            
            if (orientation == "col")
            {
                position = new Vector3(i, 0, j + pos);
            }
            else
            {
                position = new Vector3(j + pos, 0, +i);
            }

            GameObject wall = MonoBehaviour.Instantiate(Resources.Load("Prefab_Mio/Wall/Prefabs/Wall"), position, rotation, transform) as GameObject;

            if (orientation.Equals("col"))
                wall.transform.localScale = new Vector3((float)length, wall.transform.localScale.y, 1f);
            else
                wall.transform.localScale = new Vector3(1f, wall.transform.localScale.y, (float)length);

            return wall;
        }
    }

}