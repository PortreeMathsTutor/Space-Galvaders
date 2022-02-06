using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioWhenInRange : MonoBehaviour
{
    private bool doThisOnlyOnce;
    public float _height =11;
public AudioClip doup;
    // Start is called before the first frame update
    void Start()
    {
        doThisOnlyOnce = true;
       
    }

    // Update is called once per frame
    void Update()
    {
      

            if (transform.position.y<_height)
            {
                if (doThisOnlyOnce)
                {
                    AudioSource.PlayClipAtPoint(doup, transform.position);
                    doThisOnlyOnce = false;
                }
            }
       
    }
}
