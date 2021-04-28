using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public GameObject products;
    public GameObject producers;
    public bool toggleBoolProducts;
    public bool toggleBoolProducers;


    public void OnProducts()
    {
        toggleBoolProducts = !toggleBoolProducts;
        products.SetActive(toggleBoolProducts);
    }
    public void OnProducers()
    {
        toggleBoolProducers = !toggleBoolProducers;
        producers.SetActive(toggleBoolProducers);
    }


    // Start is called before the first frame update
    void Start()
    {
        products.SetActive(toggleBoolProducts);
        producers.SetActive(toggleBoolProducers);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
