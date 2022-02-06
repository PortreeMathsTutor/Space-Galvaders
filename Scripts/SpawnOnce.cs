using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnce : MonoBehaviour
{public float timeTillSpawn;
   private bool doThisOnlyOnce;
    public GameObject prefab;

    void Start()
    {
        doThisOnlyOnce = true;
    }

    void FixedUpdate()
    {
        if (doThisOnlyOnce) {
            if (Time.time > timeTillSpawn)
            {
                Instantiate(prefab, transform.position, Quaternion.identity);
                doThisOnlyOnce = false;
            }
        }
   
    }
}
