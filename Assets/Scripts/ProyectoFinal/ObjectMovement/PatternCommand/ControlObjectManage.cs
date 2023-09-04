using Control.Command;
using Control.Command.Move;
using Control.Command.Rotate;
using Control.Command.Scale;
using System.Collections.Generic;
using UnityEngine;

namespace Control.Manage
{
    public class ControlObjectManage : MonoBehaviour
    {
        private GameObject objeto;
        private List<ICommandControl> commands;

        // Start is called before the first frame update
        void Start()
        {
            commands = new List<ICommandControl>();
            commands.Add(new MoveObjectLeft());
            commands.Add(new MoveObjectRight());
            commands.Add(new MoveObjectForward());
            commands.Add(new MoveObjectBack());
            commands.Add(new MoveObjectUp());
            commands.Add(new MoveObjectDown());

            commands.Add(new RotateObjectLeft());
            commands.Add(new RotateObjectRight());
            commands.Add(new RotateObjectForward());
            commands.Add(new RotateObjectBack());
            commands.Add(new RotateObjectUp());
            commands.Add(new RotateObjectDown());

            commands.Add(new IncreaseObject());
            commands.Add(new DecreaseObject());
        }

        public void SetHouse(GameObject house)
        {
            objeto = house;
        }

        public void ExecuteCommand(int command)
        {
            commands[command].Execute(objeto);
        }

    }
}