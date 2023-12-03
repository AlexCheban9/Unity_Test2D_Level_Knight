using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueNextLvl : MonoBehaviour
{
    [SerializeField] private AudioSource AudioStatue;
    [SerializeField] private GameObject Light; 
    [SerializeField] private GameObject Canvas;

   private void OnTriggerEnter2D(Collider2D col)
	
     {
           if (col.tag == "Player") 
        {
           StartCoroutine(instObj());
           AudioStatue.enabled = true;
           Light.SetActive(true); 
        }
     }

    IEnumerator instObj()

     {
        yield return new WaitForSeconds(3f);
        Canvas.SetActive(true); 
        Time.timeScale = 0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
     }
}
