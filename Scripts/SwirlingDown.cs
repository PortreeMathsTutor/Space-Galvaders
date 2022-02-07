using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwirlingDown : MonoBehaviour
{
    private float timer_;
    private GameObject player;
    private float speed = 2f;
  
    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        timer_ += Time.deltaTime*3;
        if (transform.position.y < -15)
        {
            Destroy(gameObject);
        }

      Vector3 newPosition = new Vector3(Mathf.Sin(timer_) * 50f, Mathf.Cos(timer_) * 50f - 35f, 0);
        transform.position = Vector2.MoveTowards(transform.position, newPosition, speed * Time.deltaTime);
      
        if (player != null)
        {
           transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
}
