using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Utilities.Solvers;

public class ApplicationManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject Option1, Option2, Keyboard,_decisionPoints;
    [SerializeField]
    private Transform _menuPos;
    [SerializeField]
    private GameObject _menu,_car;
    [SerializeField]
    private Vector3 _defaultScale;
    public enum Modes {Expert,Simple,Reset }
    private  Modes CurrentMode;
    [SerializeField]
    private ObjectManipulator _object;
    [SerializeField]
    private BoundsControl _audiBounds;
    [SerializeField]
    private BoxCollider _audiCollider;
    [SerializeField]
    private RadialView _radialView;
    [SerializeField]
    public float _timeDelay;
    void Start()
    {
        CurrentMode = Modes.Expert;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ExpertMode()
    {
        if (CurrentMode == Modes.Simple)
        {
            _menu.SetActive(true);
            Option1.SetActive(false);
            Option2.SetActive(false);
            Keyboard.SetActive(false);
            _decisionPoints.SetActive(false);
            _audiBounds.enabled = true;
            _audiCollider.enabled = true;
            _object.enabled = true;
            CurrentMode = Modes.Expert;
        }
    }
    public void SimpleMode()
    {
        if(CurrentMode==Modes.Expert)
        {
            _menu.SetActive(false);
            _audiBounds.enabled = false;
            _audiCollider.enabled = false;
            _object.enabled = false;
            CurrentMode = Modes.Simple;

        }
    }
    public void ResetMode()
    {
        if(CurrentMode==Modes.Expert)
        {
            _car.transform.localScale = _defaultScale;
            _radialView.enabled = true;
            Invoke("delayreset", _timeDelay);
           
        }

    }
    private void delayreset()
    {
        _radialView.enabled = false;
        _menu.transform.position = _menuPos.position;
        _menu.transform.rotation = _menuPos.transform.rotation;
        
    }
}
