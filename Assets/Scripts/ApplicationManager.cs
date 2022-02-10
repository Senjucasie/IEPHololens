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
    private GameObject _option1, _option2, _keyBoard,_decisionPoints;
    [SerializeField]
    private Transform _menuPos;
    [SerializeField]
    private GameObject _menu,_car;
    private readonly Vector3 _defaultScale=new Vector3(0.014f,0.014f,0.014f);
    public enum Modes {Expert,Simple,Reset }
    private  Modes CurrentMode;
    [SerializeField]
    private ObjectManipulator _audiManipulator;
    [SerializeField]
    private BoundsControl _audiBounds;
    [SerializeField]
    private BoxCollider _audiCollider;
    [SerializeField]
    private RadialView _radialView;
    [SerializeField]
    public float _timeDelay;
    [SerializeField]
    private BoxCollider[] _tyreCollider;
    private ApplicationState _currentState;
    private bool _firstPass;
    private Simple _simple;
    private Expert _expert;
    private Reset _reset;


    public BoxCollider AudiCollider{ get => _audiCollider; }
    public BoundsControl AudiBounds{get => _audiBounds;}
    public ObjectManipulator AudiManipulator{get => _audiManipulator;}
    public GameObject Option1 { get => _option1; }
    public GameObject Option2 { get => _option2; }
    public GameObject Menu { get => _menu; }
    public GameObject Keyboard { get => _keyBoard; }
    public GameObject DecisionPoints { get => _decisionPoints; }
    public GameObject Car { get => _car; }
    public RadialView AudiRadial { get => _radialView; }
    public Vector3 DefaultScale { get => _defaultScale; }
    public Transform Menutransform { get => _menuPos; }



    void Start()
    {
        _firstPass = true;
        CurrentMode = Modes.Simple;
        _simple = new Simple(this);
        _expert = new Expert(this);
        _reset = new Reset(this,_timeDelay);
        _currentState = _simple;
    }
   
    public void SetState(ApplicationState newstate)
    {
        _currentState.Exit();
        _currentState = newstate;
        _currentState.Enter();
    }
    public void ExpertMode()
    {
        SetState(_expert);
        _currentState.Update();
    }

    public void SimpleMode()
    {
        SetState(_simple);
        _currentState.Update();
    }

    public void ResetMode()
    {
        SetState(_reset);
        _currentState.Update();
    }
  
}
