using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockScript : MonoBehaviour
{
  
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Projectile")
        {
            Destroy(gameObject);

            if (col.gameObject != null)
            {
                Destroy(col.gameObject);
            }
        }
     
        if (col.gameObject.tag == "EnemyProjectile")
        {
            Destroy(gameObject);
            if (col.gameObject != null)
            {
                Destroy(col.gameObject);
            }
        }
    }

}
