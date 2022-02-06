using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInvader : MonoBehaviour
{
  
    public float _height = 11;
    public AudioClip doup;
    public float speed = 1f;
    private float timeSinceStart = 0f;
    public float timeInterval;
    private Vector3 scaleChange;
    private int oddEven;
    void Start()
    {
     
        scaleChange = new Vector3(-0.3f, 0, 0);
        oddEven = 1;
    }

   

    // Update is called once per frame
    void FixedUpdate()
    {
     
        if (transform.position.y < -15)
        {
            Destroy(gameObject);
        }
        if (transform.position.x>10) {
            speed = -speed;
            transform.position = transform.position + new Vector3(0,-0.1f, 0);
        }
        if (transform.position.x <- 10) {
            speed = -speed;
            transform.position = transform.position + new Vector3(0, -0.1f, 0);
        }
        oddEven += 1;
        timeSinceStart = timeSinceStart + 1f;
        if (timeSinceStart > timeInterval)
        {
            if (oddEven % 2 == 0)
            { transform.localScale += scaleChange;
                transform.position = transform.position + new Vector3(speed, 0, 0);
            }
            else
            { transform.localScale -= scaleChange;
                transform.position = transform.position + new Vector3(speed, 0, 0);
            }
            if (transform.position.y < _height)
            {
                AudioSource.PlayClipAtPoint(doup, transform.position);
            }
            timeSinceStart = 0;

        }
    }
}
