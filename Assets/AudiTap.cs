using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

public class AudiTap : MonoBehaviour,IMixedRealityInputHandler
{
    [SerializeField]
    private float _currentDelay = 0, _maxDelay = 1;
    [SerializeField]
    private bool _Timer = false;
    [SerializeField]
    private MaterialManager _materialManager;
    public void Start()
    {
        
    }
    public void Update()
    {
        
    }
    public void OnInputDown(InputEventData eventData)
    {
      
    }

    public void OnInputUp(InputEventData eventData)
    {
        Debug.Log(eventData.MixedRealityInputAction.Description);
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

    private void singletap()
    {
     
    }
    private void doubletap()
    {
        _materialManager.Showtyres();
    }
    private void resettimer()
    {
        _currentDelay = 0;
        _Timer = false;
    }
}


