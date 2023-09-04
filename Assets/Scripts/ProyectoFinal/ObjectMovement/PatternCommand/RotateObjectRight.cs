using UnityEngine;

namespace Control.Command.Rotate
{
    public class RotateObjectRight : ICommandControl
    {
        private const float SPEED = 5f;

        public void Execute(GameObject house)
        {
            house.transform.Rotate(Vector3.right, SPEED);
        }
    }
}
