using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Generator : MonoBehaviour
{
    public int loops = 0;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate(prefab);;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // generated(0, Vector3.one, 0);
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            generated(10, default, 100);
        
        }
    }

    public void generated(int loops, Vector3 point, float radius)
    {
    
        for (int i = 0; i < this.loops; i++)
        {
            var radians = 2 * Mathf.PI / this.loops * i;
    
           
            var vertical = Mathf.Sin(radians);
            var horizontal = Mathf.Cos(radians);
    
            // var spawnDir = new Vector3(horizontal, 0, vertical);
            
            var spawnDir = new Vector3(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
            
            var spawnPos = point + spawnDir * radius; 
            
            var enemy = Instantiate(prefab, spawnPos, Quaternion.identity) as GameObject;
        }
    }
}
