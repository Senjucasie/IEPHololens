using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToogleColors : MonoBehaviour
{
    public GameObject colors;
    public bool toggleBoolColors;


    public void OnColors()
    {
        toggleBoolColors = !toggleBoolColors;
        colors.SetActive(toggleBoolColors);
    }
}
