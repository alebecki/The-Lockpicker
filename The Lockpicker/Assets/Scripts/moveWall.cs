using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWall : MonoBehaviour
{
    [SerializeField] Transform point1;
      [SerializeField] Transform point2;
  
      private float moveSpeed = 1.0f;
      private float waitTime = 1.0f;
  
      private void Update()
      {
          Move();
      }
  
      private void Move()
      {
          //Create a float that goes back and forth between `-waitTime * 0.5f` and `1 + waitTime * 0.5f`
          float timer = Mathf.PingPong(moveSpeed * Time.time, 1 + waitTime) - waitTime * 0.5f;
          // Clamp the value between 0 and 1
          // so when timer ∈ [-waitTime * 0.5f , 1] or timer ∈ [1, 1 + waitTime * 0.5f ],
          // the object will be stopped
          timer = Mathf.Clamp( timer, 0, 1 );
 
          transform.position = Vector3.Lerp(point1.position, point2.position, timer);
      }
}
