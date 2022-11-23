using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectPlayer : MonoBehaviour
{
    public GameObject cam;
    public GameObject cam2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cam.SetActive(true);
            cam2.SetActive(false);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cam2.SetActive(true);
            cam.SetActive(false);
        }
    }
}
