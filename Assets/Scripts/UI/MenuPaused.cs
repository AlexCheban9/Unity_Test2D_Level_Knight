using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPaused : MonoBehaviour
{
    public GameObject menuPaused;
    public static bool isMenuPaused = false;
  
  void Update()
     {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isMenuPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
 
      public void Resume()
    {
        menuPaused.SetActive(false);
        Time.timeScale = 1f;
        isMenuPaused = false;
        AudioListener.volume = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Pause()
    {
        menuPaused.SetActive(true);
        Time.timeScale = 0f;
        isMenuPaused = true;
        AudioListener.volume = 0f;
        Cursor.lockState = CursorLockMode.None;
    }


    private void Start()
    {
        menuPaused.SetActive(false);
        AudioListener.volume = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    Time.timeScale = 1f;
    }
  
    private void MunePausedContinue()
    {
     isMenuPaused = false;
    }
  
    public void ExitGame()
    {
    Debug.Log("Игра закрылась");
    Application.Quit();
    }
}
