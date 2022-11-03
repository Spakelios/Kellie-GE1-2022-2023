using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class killTank : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
     if(other.CompareTag("enemy"))
     {
         GetComponent<Animator>().Play("woah");
         StartCoroutine(die());
         DataStorage.block -= 1;

     }

     IEnumerator die()
     {
         GetComponent<BoxCollider>().enabled = false;
         yield return new WaitForSeconds(5f);
         
         Destroy(gameObject);
     }
    }
}
