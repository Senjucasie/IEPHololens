using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

public class AudiInteractable : MonoBehaviour,IMixedRealityInputHandler
{
    [SerializeField]
    private float _currentDelay=0, _maxDelay=1;
    [SerializeField]
    private bool _Timer=false ;

    public void OnInputDown(InputEventData eventData)
    {
       // Debug.Log(eventData.MixedRealityInputAction.Description);
        if(!_Timer)
        {
            _Timer = true;
            Invoke("TestSingletap", 1f);
        }
        else
        {
            CancelInvoke("TestSingletap");
            //_currentDelay = 0;
           // _Timer = false;
            Debug.Log("Double Tap");
        }
    }

    public void OnInputUp(InputEventData eventData)
    {
      //  Debug.Log(eventData.MixedRealityInputAction.Description);
      
    }

    private void TestSingletap()
    {
        Debug.Log("Single Tap");
    }



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
                _currentDelay = 0;
                _Timer = false;
            }
        }
    }
    
}
