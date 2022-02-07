using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KillEnemies : MonoBehaviour
{
    public AudioClip death;

    public static int score = 0;

    private void Start()
    {
        score = 0;
    }

  

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Enemy")
        {
            AudioSource.PlayClipAtPoint(death, transform.position);
            score = score + 10;

            Debug.Log(score);
            if (col.gameObject != null)
            {
                Destroy(col.gameObject);

            }
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
