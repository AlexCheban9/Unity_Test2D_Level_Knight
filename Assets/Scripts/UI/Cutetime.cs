using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutetime : MonoBehaviour
{
   [SerializeField] private GameObject Text;
   private bool _off = false;

    private void OnTriggerStay2D(Collider2D col)	
       {
           if (col.tag == "Player") 
         {
               if(!_off)
              {
                Text.SetActive(true);
              }
         }
       }
 
     private void OnTriggerExit2D(Collider2D col)
       {    
            if (col.tag == "Player") 
         {
            Text.SetActive(false); 
            _off = true;
         }
       }
}
