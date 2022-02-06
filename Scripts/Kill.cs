using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{
    public AudioClip death;
    public AudioClip deathPlayer;
    public static int score = 0;

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

        SceneManager.LoadScene(3);
  
    }
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "Projectile")
      {
            StartCoroutine(ExampleCoroutine());

            Debug.Log(score);
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

}
