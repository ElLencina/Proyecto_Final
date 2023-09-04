using UnityEngine;

namespace Control.Command.Scale
{
    public class IncreaseObject : ICommandControl
    {
        private const float SIZE = 0.008f;

        public void Execute(GameObject house)
        {
            house.transform.localScale += Vector3.one * SIZE;
        }
    }
}
