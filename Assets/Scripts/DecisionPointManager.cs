using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit.UI;
using TMPro;
using System.Collections;

public class DecisionPointManager : MonoBehaviour
{
    //public Interactable intq;
    public List<DecisionDataHolder> Dataholder;
    [SerializeField]
    private GameObject _prefabButn,_prefabOption2;
    [SerializeField]
    private Transform _parent,_parentoption2;
    [SerializeField]
    private GridObjectCollection _grid,_gridOption2;
    [SerializeField]
    private InteractableToggleCollection _toggleDp,_toggleoption1;
    [SerializeField]
    private ScrollingObjectCollection _scrollingDecision, _scrollingOption;
    // Start is called before the first frame update
    void Start()
    {
        Dataholder.Add(new DecisionDataHolder("Decision Point1", "\u2022<indent=.5em>decision point1</indent>", Color.red));
        Dataholder.Add(new DecisionDataHolder("Decision Point2", "\u2022<indent=.5em>decision point2</indent>", Color.green));
        Dataholder.Add(new DecisionDataHolder("Decision Point3", "\u2022<indent=.5em>decision point3</indent>", Color.green));
        Dataholder.Add(new DecisionDataHolder("Decision Point4", "\u2022<indent=.5em>decision point4</indent>", Color.yellow));
    }

    public void AddNewComment(Color color,string title,string content)
    {
      DecisionDataHolder  data = new DecisionDataHolder(title,content,color);
      Dataholder.Add(data);
        UpdateGrid(data);
        UpdateOption2( data);
    }
    public void UpdateGrid(DecisionDataHolder data)
    {
        GameObject butn = Instantiate(_prefabButn, _parent, false);
        _toggleDp.ToggleList.Add(butn.GetComponent<Interactable>());
        var textmesh = butn.GetComponentInChildren<TextMeshPro>();
        butn.GetComponent<OnClickDecision>()._uimanager = GetComponent<UIManager>();
        textmesh.text = data.Title;
        textmesh.color = data.Colour;
        _grid.UpdateCollection();
        _scrollingDecision.Reset();
        // _grid.UpdateCollection();
    }

    public void UpdateOption2(DecisionDataHolder data)
    {
        GameObject butn = Instantiate(_prefabOption2, _parentoption2, false);
      // _toggleoption1.ToggleList.Add(butn.GetComponent<Interactable>());
        var listholder = _toggleoption1.ToggleList;
        listholder.Add(butn.GetComponent<Interactable>());
        _toggleoption1.ToggleList = listholder;
        butn.GetComponent<OnClickOption2>()._uiManager = GetComponent<UIManager>();
        var textmesh = butn.GetComponentInChildren<TextMesh>();
        textmesh.text = data.Title;
        textmesh.color = data.Colour;
        _gridOption2.UpdateCollection();
        _scrollingOption.Reset();
    }
 
      
        
    
}


