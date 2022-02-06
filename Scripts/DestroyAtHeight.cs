using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAtHeight : MonoBehaviour
{
    public float _height = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < _height)
        {
            Destroy(gameObject);
        }
    }
}
