using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class ShowText : MonoBehaviour
{
    public TextMeshProUGUI text;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            text.text = "Speed: " + RotateMe.speed + " Manual Mode S";
        }
        else if(Input.GetKey(KeyCode.D))
        {
            text.text = "Speed: " + RotateMe.speed + " Manual Mode D";
        }
        else
        {
            text.text = "Speed: " + RotateMe.speed + " Auto";
        }
    }
}
