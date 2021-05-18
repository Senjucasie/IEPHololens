using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickOption2 : MonoBehaviour
{
    public UIManager _uiManager;

    public void OnClick()
    {
        _uiManager.OnclickOption2(transform.GetSiblingIndex());
    }
}
