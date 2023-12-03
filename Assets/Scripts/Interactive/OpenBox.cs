using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : MonoBehaviour
{
    [SerializeField] private GameObject box; 
    [SerializeField] private AudioSource AudioRock;
    [SerializeField] private GameObject LetterF;
    private bool _off = false;

    private void OnTriggerStay2D(Collider2D other)
	
       {
            if(!_off)
           {
            LetterF.SetActive(true);
           }
 
            if (Input.GetKeyDown(KeyCode.F)) 
           {
            box.GetComponent<Collider2D>().enabled = false; 
            box.GetComponent<Animator> ().enabled = true;
            AudioRock.enabled = true; 
            _off = true;
           }
       }

     private void OnTriggerExit2D(Collider2D other)
        {      
           box.GetComponent<Animator> ().enabled = false;
           AudioRock.enabled = false;  
           LetterF.SetActive(false); 
        }
}
