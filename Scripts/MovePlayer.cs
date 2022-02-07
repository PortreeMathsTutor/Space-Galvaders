using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody2D myrigidbody;
 
    public float movementspeed = 10f;

    private float horizontal;
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
      
        myrigidbody.velocity= new Vector2(0 , 0.0f);
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.01f);

        //After we have waited 5 seconds print the time again.
      
        myrigidbody.velocity = new Vector2(0.0f, 0.0f);
    }
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if (transform.position.x > 10)
        {
          
            transform.position =new Vector2(10, -11);
        }
        if (transform.position.x < -10)
        {
        
            transform.position =  new Vector2(-10,-11);
        }
        horizontal = Input.GetAxis("Horizontal");

        myrigidbody.velocity = new Vector2(horizontal * movementspeed,0);
        if (Input.GetKeyUp("d"))
        {
            StartCoroutine(ExampleCoroutine());
           }
        if (Input.GetKeyUp("a"))
        {
            StartCoroutine(ExampleCoroutine());
        }

    }
   
   
   
    
   
}
