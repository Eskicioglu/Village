using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Village_practice_game.Animation
{
 public class CharacterAnimation
 {

    Animator _animator;

    public CharacterAnimation(PlayerControllers entity)
    {
        _animator = entity.GetComponentInChildren<Animator>();
    }

    public void MoveAnimation(float moveSpeed)
    {
        if(_animator.GetFloat("Speed_f") == moveSpeed) return;    

            _animator.SetFloat("Speed_f",moveSpeed,0.1f,Time.deltaTime);
        
    }












}











}

