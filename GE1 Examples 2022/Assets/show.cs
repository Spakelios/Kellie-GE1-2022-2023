using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class show : MonoBehaviour
{
    public TextMeshProUGUI funnyNumbers;
    
    void Update()
    {
        funnyNumbers.text = "Tanks: " + DataStorage.block;
    }
}
