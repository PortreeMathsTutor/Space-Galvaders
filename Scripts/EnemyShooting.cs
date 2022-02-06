using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public GameObject prefab;
  
    public float timeInterval = 30;
    public float theTimer;

    private void Start()
    {
        timeInterval = Random.Range(7, timeInterval);
    }



    // Update is called once per frame
    void Update()
    {
        if (transform.position.y<3)
        {
            theTimer += Time.deltaTime;
            if (theTimer > timeInterval)
            {

                Instantiate(prefab, transform.position, Quaternion.identity);
                theTimer = 0;

            }
        }
       


    }
}
