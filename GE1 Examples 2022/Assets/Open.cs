using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Open : MonoBehaviour
{
    public TextMeshProUGUI words;
    public GameObject text;
    public Animator Animator;
    private int times;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Animator.Play("Open");
        }

        if(other.CompareTag("Player"))

        {
            words.text = "Number of times: " + times;
            text.SetActive(true);
            times++;
        }
    }
}
