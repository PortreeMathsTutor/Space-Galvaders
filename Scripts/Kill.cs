using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{
    public static bool youAreDeadScoreReset = false;
  
    public AudioClip deathPlayer;

    private int scene;
    void Start()
    {
        youAreDeadScoreReset = false;
     
  
    }


    
    IEnumerator ExampleCoroutine2()
    {
   
        AudioSource.PlayClipAtPoint(deathPlayer, transform.position);
   
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.5f);

        //After we have waited 5 seconds print the time again.
        youAreDeadScoreReset = true;
        SceneManager.LoadScene(scene+4);
  
    }
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D col)
    {
       
        if (col.gameObject.tag == "Player")
        {
            StartCoroutine(ExampleCoroutine2());
        


        }
        if (col.gameObject.tag == "Block")
        {
          


            if (col.gameObject != null)
            {
                Destroy(col.gameObject);

            }
        }
    }
    private void Update()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
    }
}
