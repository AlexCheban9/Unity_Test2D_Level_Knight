using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFX_off : MonoBehaviour
{
    [SerializeField] private GameObject Vfx;


    private void OnTriggerStay2D(Collider2D col)	
       {
           if (col.tag == "Player") 
         {
              
                Vfx.SetActive(true);
         }
       }
 
     private void OnTriggerExit2D(Collider2D col)
       {    
            if (col.tag == "Player") 
         {
            Vfx.SetActive(false); 

         }
       }
}
