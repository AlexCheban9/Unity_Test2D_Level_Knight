using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSound : MonoBehaviour
{
    [SerializeField] private AudioSource AudioFire; 

    private void OnTriggerEnter2D(Collider2D other)
	
   {
        AudioFire.enabled = true;
   }

    private void OnTriggerExit2D(Collider2D other)
       {      
           AudioFire.enabled = false; 
       }

}
