using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllPowerUps : MonoBehaviour
{
    public GameObject LeftBullet;
    public GameObject rightBullet;
    public GameObject middleBullet;
    public GameObject normalBullet;

    public bool shooting;
    public bool powerUp1;
    public AudioClip fire;
    public bool canFire;
    public float timeInterval = 30;
    public float timeBetweenBullets = 0.5f;

    private int timerPowerUp1;


    // Start is called before the first frame update
    void Start()
    {
        powerUp1 = false;
        canFire = true;
    }
    IEnumerator ExampleCoroutine()
    {
        AudioSource.PlayClipAtPoint(fire, transform.position);
 
        if (powerUp1) {
            Instantiate(LeftBullet, transform.position, Quaternion.identity);
            Instantiate(rightBullet, transform.position, Quaternion.identity);
        Instantiate(middleBullet, transform.position, Quaternion.identity);
        }
        else { Instantiate(normalBullet, transform.position, Quaternion.identity); }
        canFire = false;
                yield return new WaitForSeconds(timeBetweenBullets);
        canFire = true;
    }

    IEnumerator ExampleCoroutine2()
    {
        yield return new WaitForSeconds(30);
        powerUp1 = false;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PowerUp1")
        {
            powerUp1 = true;
            StartCoroutine(ExampleCoroutine2());
            Destroy(col.gameObject);
        }

    }

    private void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            shooting = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            shooting = false;
        }





        if (canFire)
        {
            if (shooting) { StartCoroutine(ExampleCoroutine()); }

        }
    }
}
