using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitMethod : MonoBehaviour
{ // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        if (Input.GetKey("r")) { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); }
    }
}
