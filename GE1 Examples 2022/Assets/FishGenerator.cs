using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishGenerator : MonoBehaviour
{

    void Start()
    {
        {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                GameObject cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                
                cube.transform.rotation = transform.rotation;
                cube.transform.localScale = new Vector3(3, 2, 1);
                cube.GetComponent<Renderer>().material.color = Color.grey;
                
                cube2.transform.rotation = transform.rotation;
                cube2.transform.localScale = new Vector3(3, 2, 1);
                cube2.transform.localPosition = new Vector3(3,0,0);
                cube2.GetComponent<Renderer>().material.color = Color.grey;
                
                cube3.transform.rotation = transform.rotation;
                cube3.transform.localScale = new Vector3(3, 2, 1);
                cube3.transform.localPosition = new Vector3(-3,0,0);
                cube3.GetComponent<Renderer>().material.color = Color.grey;


        }
    }
}
