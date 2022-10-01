using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = System.Random;

public class Generator : MonoBehaviour
{
    public int loops = 1;
    public GameObject prefab;

    private Material newMat;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefab);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
