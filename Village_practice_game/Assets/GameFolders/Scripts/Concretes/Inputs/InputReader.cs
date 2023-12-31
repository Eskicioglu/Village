using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Village_practice_game.Abstracts.Inputs
{
   public class InputReader : MonoBehaviour,IInputReader //Invoke UnityEvent seçtiğimizden MonoBehavior var seçip bırakcağımızdan
   {  
    public Vector3 Direction{get; private set;}
    public Vector2 Rotation{get; private set;}
     
    public void OnMove(InputAction.CallbackContext context)
    {
       Vector2 oldDirection = context.ReadValue<Vector2>();
       Direction = new Vector3(oldDirection.x,0f,oldDirection.y);
    }

    public void OnRotator(InputAction.CallbackContext context)
    {
      Rotation = context.ReadValue<Vector2>();
    }




   }















   
}

