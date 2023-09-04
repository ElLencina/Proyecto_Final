using UnityEngine;

namespace Control.Command.Rotate
{
    public class RotateObjectLeft : ICommandControl
    {
        private const float SPEED = 5f;

        public void Execute(GameObject house)
        {
            house.transform.Rotate(Vector3.left, SPEED);
        }
    }
}
