using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{ // Instantiates prefabs in a circle formation
    public GameObject prefab;
    public int numberOfObjects = 20;
    public float radius = 24f;
    void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfObjects;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            Vector3 pos = transform.position + new Vector3(x, z, 0);
           
            Instantiate(prefab, pos, Quaternion.identity);
        }
    }
}
