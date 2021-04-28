using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class testrotate : MonoBehaviour
{
    bool rotate =false;

    public void Rotating()
    {
        rotate = !rotate;
    }

    // Update is called once per frame
    public void Update()
    {
        if (rotate)
        {
            transform.Rotate(new Vector3(150, 300, 60) * Time.deltaTime);
            this.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        }
    }
}
