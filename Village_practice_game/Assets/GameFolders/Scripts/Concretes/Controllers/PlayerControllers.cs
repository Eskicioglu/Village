using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using Village_practice_game.Abstracts.Movements;
using Village_practice_game.Animation;
using Village_practice_game.Movements;

namespace Village_practice_game
{
  public class PlayerControllers : MonoBehaviour
  {
    [Header("Movement Information")]
    [SerializeField]  float _moveSpeed = 10f;
    [SerializeField]  float _turnSpeed =10f; 
    [SerializeField] Transform _turnTransform;

    //---------------------------------------Çağırılan Interface-Sınıflar vb ------------------------------------------------
    IInputReader _input;
    IMover _mover;
    IRotator _xRotation;
    IRotator _yRotation;
    Vector3 _direction;
    CharacterAnimation _animation;
    //-------------------------------------------Properity------------------------------------------------------------------
    public Transform TurnTransform => _turnTransform;


    //----------------------------------------------------------------------------------------------------------------------
    private void Awake()
    {
      _input = GetComponent<IInputReader>();
      _mover = new MoveWithCharacterController(this); //Sonra bunu değiştirebiliriz ana kodumuza zarar vermez o yüzden böyle yaptık
      _animation = new CharacterAnimation(this);
      _xRotation = new RotatorX(this);
      _yRotation = new RotatorY(this);
    }

    private void Update()
    {
      _direction = _input.Direction;

      _xRotation.RotationAction(_input.Rotation.x,_turnSpeed);
      _yRotation.RotationAction(_input.Rotation.y,_turnSpeed);
    }

    private void FixedUpdate()
    {
      _mover.MoveAction(_direction, _moveSpeed);
    }
    private void LateUpdate()
    {
      _animation.MoveAnimation(_direction.magnitude);
    }





  }











}
