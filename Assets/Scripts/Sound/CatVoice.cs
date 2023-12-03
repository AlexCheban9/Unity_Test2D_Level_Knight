using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatVoice : MonoBehaviour
{
   [SerializeField] private AudioSource AudioCat;

   private void OnTriggerStay2D(Collider2D col)
	
       {
           if (col.tag == "Player") 
		{
		   AudioCat.enabled = true;	
		}
       }

   private void OnTriggerExit2D(Collider2D col)
        {      
           if (col.tag == "Player") 
		{
		   AudioCat.enabled = false;  
		}
        }
}
