using UnityEngine;

namespace HouseFactory
{
    public class Window : IHouse
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

            GameObject window = MonoBehaviour.Instantiate(Resources.Load("Prefab_Mio/Window/Prefabs/Window"), position, rotation, transform) as GameObject;

            if (orientation.Equals("col"))
                window.transform.localScale = new Vector3((float)length, window.transform.localScale.y, 1f);
            else
                window.transform.localScale = new Vector3(1f, window.transform.localScale.y, (float)length);

            return window;
        }
    }
}