using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;
using System.Collections.Generic;

public class AudiInteractable : MonoBehaviour,IMixedRealityInputHandler
{
    [SerializeField]
    private float _currentDelay=0, _maxDelay=1;
    [SerializeField]
    private bool _Timer=false ;
    [SerializeField]
    private MaterialManager _materialManager;
    [SerializeField]
    private List<GameObject> _skipList;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_Timer)
        {
            _currentDelay += Time.deltaTime;
            if (_currentDelay >= _maxDelay)
            {
                resettimer();
            }
        }
    }

    public void OnInputDown(InputEventData eventData)
    {
        // Debug.Log(eventData.MixedRealityInputAction.Description);
        if (!_Timer)
        {
            _Timer = true;
            Invoke("singletap", 1f);
        }
        else
        {
            CancelInvoke("singletap");
            doubletap();
        }
    }

    public void OnInputUp(InputEventData eventData)
    {
    }

    private void singletap()
    {
       // Debug.Log("Single Tap");
    }
    private void doubletap()
    {
       // _materialManager.TransparentEffect(_skipList);
    }
    private void resettimer()
    {
        _currentDelay = 0;
        _Timer = false;
    }
}
