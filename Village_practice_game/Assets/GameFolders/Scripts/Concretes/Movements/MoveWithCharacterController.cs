using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Village_practice_game.Abstracts.Movements;


namespace Village_practice_game.Movements
{
    public class MoveWithCharacterController : IMover
    {
        CharacterController _characterController;
        public MoveWithCharacterController(PlayerControllers playerControllers)
        {
            _characterController = playerControllers.GetComponent<CharacterController>();
        }

        public void MoveAction(Vector3 direction, float moveSpeed)
        {
            if (direction.magnitude == 0f) return;

            Vector3 worldPosition = _characterController.transform.TransformDirection(direction);
            Vector3 movement = worldPosition * Time.deltaTime * moveSpeed;
            _characterController.Move(movement);
        }










    }














}

