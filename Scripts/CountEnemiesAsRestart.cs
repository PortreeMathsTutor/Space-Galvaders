using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountEnemiesAsRestart : MonoBehaviour
{
    private int scene;
    void Start()
    {
      scene = SceneManager.GetActiveScene().buildIndex;
       
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Enemy");
        if (gos.Length < 1) { SceneManager.LoadScene(scene + 1); }

        GameObject[] gos2;
        gos2 = GameObject.FindGameObjectsWithTag("Player");
        if (gos2.Length < 1) { SceneManager.LoadScene(scene+4); }
    }
}
