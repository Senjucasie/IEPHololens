using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakerProducers : MonoBehaviour
{
    public GameObject producers;

    void Awake()
    {
        producers.SetActive(false);
    }
}
