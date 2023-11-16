using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;
using Village_practice_game.Movements;


namespace Village_practice_game.Movements
{
    public class RotatorY : IRotator
    {
        Transform _transform; //Camera yön ayarı için LookPosition demiştik ya bu onun için şimdi ona erişmemiz lazım

        float _tilt;
        public RotatorY(PlayerControllers playerControllers)
        {
            _transform = playerControllers.TurnTransform;
        }
        public void RotationAction(float direction,float speed)
        {
            direction *= speed*Time.deltaTime;
            _tilt = Mathf.Clamp(_tilt-direction,-30f,+30f); // Sağa sola bakarken 360 atmasını önledik
            _transform.localRotation = Quaternion.Euler(_tilt,0,0);
        }
    }

}
