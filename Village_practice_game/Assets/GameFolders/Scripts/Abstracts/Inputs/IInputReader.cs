using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public interface IInputReader //Interfaceimiz yönümüzü belirleyen
{
  Vector3 Direction {get;}
  Vector2 Rotation{get;}
}
