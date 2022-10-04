﻿using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Generator : MonoBehaviour
{
    public int loops = 1;
    public GameObject prefab;
    
    private Material newMat;
    public static string newDo;
    
    // Start is called before the first frame update
    void Start()
    {
        // Instantiate(prefab);;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            generated(1, Vector3.left, 0);
            newMat = prefab.GetComponent<MeshRenderer>().material;
            newMat.color = Color.yellow;

        }
    }

    public void generated(int num, Vector3 point, float radius)
    {
    
        for (int i = 0; i < num; i++)
        {
    
            /* Distance around the circle */
            var radians = 2 * Mathf.PI / num * i;
    
            /* Get the vector direction */
            var vertical = Mathf.Sin(radians);
            var horizontal = Mathf.Cos(radians);
    
            var spawnDir = new Vector3(horizontal, 10, vertical);
    
            /* Get the spawn position */
            var spawnPos = point + spawnDir * radius; // Radius is just the distance away from the point
    
            /* Now spawn */
            var enemy = Instantiate(prefab, spawnPos, Quaternion.identity) as GameObject;
    
            /* Rotate the enemy to face towards player */
            enemy.transform.LookAt(point);
    
            /* Adjust height */
            enemy.transform.Translate(new Vector3(0, enemy.transform.localScale.y / 2, 0));
        }
    }
}
