using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelNow : MonoBehaviour
{

public void NextLevelOne() { SceneManager.LoadScene(1); }
    public void NextLevelTwo() { SceneManager.LoadScene(2); }
    public void NextLevelTree() { SceneManager.LoadScene(3); }
  
}
