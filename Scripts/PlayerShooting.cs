using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public AudioClip fire;
    public GameObject prefab;
    public bool canFire;
    public float timeInterval = 30;
    public float theTimer;
 

    // Start is called before the first frame update
    void Start()
    {
       
        canFire = true;
    }
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        AudioSource.PlayClipAtPoint(fire, transform.position);
        Instantiate(prefab, transform.position, Quaternion.identity);
        canFire = false;

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.5f);

        //After we have waited 5 seconds print the time again.

        canFire = true;
    }

    // Update is called once per frame
    void Update()
    {
    
        theTimer += Time.deltaTime;
        if (canFire) {
            if (Input.GetKeyDown("space"))
            {
               StartCoroutine(ExampleCoroutine());
               
            }
        }
        
      
    }
}
