using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Village_practice_game.Movements;


namespace Village_practice_game.Movements
{
    public class RotatorX : IRotator
    {
        PlayerControllers _playerControllers;

        public RotatorX(PlayerControllers playerControllers)
        {
            _playerControllers = playerControllers;
        }
        public void RotationAction(float direction,float speed)
        {
            _playerControllers.transform.Rotate(Vector3.up*direction*Time.deltaTime*speed);
        }
    }

}

