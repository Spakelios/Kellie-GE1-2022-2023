using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject g;
    System.Collections.IEnumerator Spawn()
    {
        while(true)
        {
            // GameObject g = GameObject.CreatePrimitive(PrimitiveType.Cube);
            // g.AddComponent<Rigidbody>();
            // g.AddComponent<Renderer>();
            // g.GetComponent<Renderer>().material.color = Color.magenta;
            Instantiate(g);

            DataStorage.block++;

            yield return new WaitForSeconds(1f);

            if (DataStorage.block >= 4)
            {
               yield break;
            }
            
          
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        if (DataStorage.block <= 0)
        {
            DataStorage.block = 0;
        }
    }
}
