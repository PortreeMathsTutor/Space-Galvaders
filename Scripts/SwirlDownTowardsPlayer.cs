using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwirlDownTowardsPlayer : MonoBehaviour
{
    private GameObject player;
    private float speed = 1f;
    private Vector3 startPosition;
    private Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        if (transform.position.y < -15)
        {
            Destroy(gameObject);
        }

        newPosition = new Vector3(Mathf.Sin(Time.time) * 0.07f, Mathf.Sin(Time.time) * 0.02f-0.05f, 0);
        //Time.deltaTime is the amount of seconds it took for the engine to process the previous frame. 
        transform.position = transform.position + newPosition;
        if (player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
}
