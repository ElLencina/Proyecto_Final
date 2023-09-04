using UnityEngine;

namespace Control.Command.Rotate
{
    public class RotateObjectBack : ICommandControl
    {
        private const float SPEED = 5f;

        public void Execute(GameObject house)
        {
            house.transform.Rotate(Vector3.back, SPEED);
        }
    }
}
