using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakerDictationPanel : MonoBehaviour
{
    public GameObject dictationPanel;

    public void Awake()
    {
        dictationPanel.SetActive(false);
    }
}
