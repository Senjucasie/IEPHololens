using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class debuglogTest : MonoBehaviour
{
    public GameObject menu, texture;
    Vector3 menuPos;
    bool rendered;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        menuPos = menu.transform.position;
        rendered = texture.GetComponent<Renderer>().enabled;
    }
}
