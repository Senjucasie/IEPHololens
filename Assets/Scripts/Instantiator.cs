using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    private int counter = 0;
    public GameObject annotation1, annotation2;
        // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick()
    {
        counter = counter + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter==1)
        {
            annotation1.SetActive(true);
        }
        else if (counter==2)
        {
            annotation2.SetActive(true);
        }
        else
        {
            annotation2.SetActive(false);
            annotation2.SetActive(false);
        }
    }
}
