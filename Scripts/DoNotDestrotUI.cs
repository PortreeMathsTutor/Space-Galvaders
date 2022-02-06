using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestrotUI : MonoBehaviour
{

	
    // Use this for initialization
    void Start()
    {
        GameObject.DontDestroyOnLoad(gameObject);
    }
}



