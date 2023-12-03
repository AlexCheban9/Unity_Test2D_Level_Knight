using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNextLvl : MonoBehaviour
{
    public int sceneNumber; 
    public void PlayGame()

  {

   SceneManager.LoadScene(sceneNumber);
  
  }
 
  public void ExitGame()

  {
    Debug.Log("Игра закрылась");
    Application.Quit();
  }
}
