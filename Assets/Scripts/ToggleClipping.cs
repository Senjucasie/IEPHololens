using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleClipping : MonoBehaviour
{
    public GameObject clippingSphere;
    public bool toggleBoolClipping;


    public void OnClipping()
    {
        toggleBoolClipping = !toggleBoolClipping;
        clippingSphere.SetActive(toggleBoolClipping);
    }
}
