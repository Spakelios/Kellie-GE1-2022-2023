using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using Random = System.Random;

public class FishGenerator : MonoBehaviour
{
    [SerializeField] private Transform head;
    [SerializeField] private Transform tail;

    [Range(0, 5f)] public float frequency;
    void Start()
    {
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);

            tail = cube2.transform;
            head = cube3.transform;

            cube.transform.rotation = transform.rotation;
            cube.transform.localScale = new Vector3(3, 2, 1);
            cube.GetComponent<Renderer>().material.color = Color.grey;

            cube2.transform.localScale = new Vector3(3, 2, 1);
            cube2.transform.localPosition = new Vector3(3, 0, 0);
            cube2.GetComponent<Renderer>().material.color = Color.grey;
            cube2.transform.localRotation = Quaternion.AngleAxis(frequency, Vector3.forward);
            
            cube3.transform.rotation = transform.rotation;
            cube3.transform.localScale = new Vector3(3, 2, 1);
            cube3.transform.localPosition = new Vector3(-3, 0, 0);
            cube3.GetComponent<Renderer>().material.color = Color.grey;
            cube3.transform.localRotation = Quaternion.AngleAxis(frequency, Vector3.forward);

        }

    }
    
    public float theta = 40;

    private void Update()
    {
        {
            tail.transform.localRotation = Quaternion.AngleAxis(theta * frequency, Vector3.forward);
            head.transform.localRotation = Quaternion.AngleAxis(theta * frequency, Vector3.forward);
            Mathf.Sin(theta);

        }
    }

}

