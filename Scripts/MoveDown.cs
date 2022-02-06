using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
   public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {

        if (transform.position.y < -15)
        {
            Destroy(gameObject);
        }
      Vector3 newPosition = new Vector3(0f, -speed, 0f);
        //Time.deltaTime is the amount of seconds it took for the engine to process the previous frame. 
        transform.position = transform.position + newPosition;

      
         

       
    }
}
