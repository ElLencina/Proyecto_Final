using UnityEngine;

namespace Control.Command.Scale
{
    public class DecreaseObject : ICommandControl
    {
        private const float SIZE = 0.008f;

        public void Execute(GameObject house)
        {
            Vector3 sizeScale = house.transform.localScale - Vector3.one * SIZE;
            if (sizeScale.x > 0 && sizeScale.y > 0 && sizeScale.z > 0)
                house.transform.localScale = sizeScale;
        }
    }
}