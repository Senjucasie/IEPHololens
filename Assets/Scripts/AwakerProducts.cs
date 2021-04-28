using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakerProducts : MonoBehaviour
{
    public GameObject products;

    void Awake()
    {
        products.SetActive(false);
    }
}
