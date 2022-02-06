using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
  
  
    public float speed = 2f;
 
   
 

    // Update is called once per frame
    void FixedUpdate()
    {

        if (transform.position.y < -15)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > 8)
        {
            speed = -speed;
            transform.position = transform.position + new Vector3(0, -1f, 0);
            transform.Rotate(0,0, 180);
        }
        if (transform.position.x < -8)
        {
            speed = -speed;
            transform.position = transform.position + new Vector3(0, -1f, 0);
            transform.Rotate(0, 0, 180);
        }
      
   
          
          
         
                transform.position = transform.position + new Vector3(speed, 0, 0);
       
          
         

       
    }
}
