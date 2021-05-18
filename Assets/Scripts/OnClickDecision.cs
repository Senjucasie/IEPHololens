using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickDecision : MonoBehaviour
{
    
    public UIManager _uimanager;

    public void Onclick()
    {
        _uimanager.OnclickDecisionPoint(transform.GetSiblingIndex());
    }
    


}
