using UnityEngine;

namespace Control.Command.Rotate
{
    public class RotateObjectDown : ICommandControl
    {
        private const float SPEED = 0.45f;

        public void Execute(GameObject house)
        {
            house.transform.Rotate(Vector3.down, SPEED);
        }
    }
}