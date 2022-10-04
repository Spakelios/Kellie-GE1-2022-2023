using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static TMPro.TextMeshProUGUI;

public class RotateMe : MonoBehaviour
{
    [Range(0, 360)]
    public static float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(2f * speed,0,0);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1f * speed, 0);
        }
        else
        {
            transform.Rotate(0, 0, 1f * speed);
        }


    }
}
