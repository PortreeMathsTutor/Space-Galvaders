using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelNow : MonoBehaviour
{

public void NextLevel() { SceneManager.LoadScene(1); }
    public void Restart() { SceneManager.LoadScene(1); }
    
}
