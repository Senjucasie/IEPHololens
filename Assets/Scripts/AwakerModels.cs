using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakerModels : MonoBehaviour
{
    public GameObject decisionPoints;
    public bool toggle;

    void Awake()
    {
        decisionPoints.SetActive(toggle);
    }
}
