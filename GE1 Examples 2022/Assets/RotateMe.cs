using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static TMPro.TextMeshProUGUI;

public class RotateMe : MonoBehaviour
{
    [Range(0, 360)]
    public static float speed = 5;
    private Material newMat;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        newMat = GetComponent<MeshRenderer>().material;
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(2f * speed,0,0);
            newMat.color = Color.black;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1f * speed, 0);
            newMat.color = Color.cyan;
        }
        else
        {
            transform.Rotate(0, 0, 1f * speed);
            newMat.color = Color.red;
        }


    }
}
