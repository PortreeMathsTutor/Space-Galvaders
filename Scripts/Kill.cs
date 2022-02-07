using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{
    public static bool youAreDeadScoreReset = false;
    public AudioClip death;
    public AudioClip deathPlayer;
    public static int score = 0;
    private int scene;
    void Start()
    {
        youAreDeadScoreReset = false;
     
        score = 0;
    }


    IEnumerator ExampleCoroutine()
    {
      
        AudioSource.PlayClipAtPoint(death, transform.position);
        score = score + 10;

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.1f);

        //After we have waited 5 seconds print the time again.

        if (gameObject != null)
        {
        
            Destroy(gameObject);
       
        }
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
        
        if (col.gameObject.tag == "Projectile")
      {
            StartCoroutine(ExampleCoroutine());

     
            if (col.gameObject != null)
            {
                Destroy(col.gameObject);

            }
        }
        if (col.gameObject.tag == "Player")
        {
            StartCoroutine(ExampleCoroutine2());
            Destroy(col.gameObject);


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
