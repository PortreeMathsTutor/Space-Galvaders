using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    [SerializeField]
    public Vector3 _direction;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y >1.7)
        {
            Destroy(gameObject);
        }
        transform.position = transform.position +_direction;
    }
}
