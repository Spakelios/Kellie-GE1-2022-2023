using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    System.Collections.IEnumerator Spawn()
    {
        while(true)
        {
            GameObject g = GameObject.CreatePrimitive(PrimitiveType.Cube);
            g.AddComponent<Rigidbody>();
            g.AddComponent<Renderer>();
            g.GetComponent<Renderer>().material.color = Color.magenta;
            g.transform.position = Random.transform.position;

            DataStorage.block++;

            yield return new WaitForSeconds(1f);

            if (DataStorage.block >= 5)
            {
                yield break;
            }
            else if (DataStorage.block <= 5)
            {
                yield return g;
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
    }
}
