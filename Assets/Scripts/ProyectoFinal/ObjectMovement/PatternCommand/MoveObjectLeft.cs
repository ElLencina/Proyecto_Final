using UnityEngine;

namespace Control.Command.Move
{
    public class MoveObjectLeft : ICommandControl
    {
        private const float SPEED = 0.45f;

        public void Execute(GameObject house)
        {
            house.transform.position += Vector3.left * SPEED;
        }

    }
}

