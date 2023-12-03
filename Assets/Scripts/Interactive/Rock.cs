using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    [SerializeField] private GameObject rock; 
    [SerializeField] private AudioSource AudioRock;

    private void OnTriggerEnter2D(Collider2D col)
	
   {
        if (col.tag == "Player") 
      {
        rock.SetActive(true); 
        AudioRock.enabled = true;
      }
   }
}
