using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrid : MonoBehaviour
{
    // Instantiates prefabs in a circle formation
    public GameObject prefab;
    public int numberOfObjectsPerLine = 8;
    public int numberOfLines = 2;

    void Start()
    {
        for (int i = 0; i < numberOfObjectsPerLine; i++)
        {
            for (int j = 0; j < numberOfLines; j++)
            {
                float x = i * 2;
                float y = j * 2;
                Vector3 pos = transform.position + new Vector3(x, y, 0);
                Instantiate(prefab, pos, Quaternion.identity);
            }
        }
    }
}
