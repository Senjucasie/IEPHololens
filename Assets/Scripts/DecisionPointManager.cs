using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit.UI;

public class DecisionPointManager : MonoBehaviour
{
    public Interactable intq;
    public List<DecisionDataHolder> Dataholder;
    [SerializeField]
    private GameObject _prefabButn,_prefabOption2;
    [SerializeField]
    private Transform _parent,_parentoption2;
    [SerializeField]
    private GridObjectCollection _grid,_gridOption2;
    [SerializeField]
    private InteractableToggleCollection _toggleDp,_toggleoption1;
    // Start is called before the first frame update
    void Start()
    {
        Dataholder.Add(new DecisionDataHolder("Decision Point1", "\u2022<indent=.5em>I am decision point1", Color.red));
        Dataholder.Add(new DecisionDataHolder("Decision Point2", "\u2022<indent=.5em>I am decision point2", Color.green));
        Dataholder.Add(new DecisionDataHolder("Decision Point3", "\u2022<indent=.5em>I am decision point3", Color.green));
        Dataholder.Add(new DecisionDataHolder("Decision Point4", "\u2022<indent=.5em>I am decision point4", Color.yellow));
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
        var textmesh = butn.GetComponentInChildren<TextMesh>();
        butn.GetComponent<OnClickDecision>()._uimanager = GetComponent<UIManager>();
        textmesh.text = data.Title;
        textmesh.color = data.Colour;
        _grid.UpdateCollection();
    }

    public void UpdateOption2(DecisionDataHolder data)
    {
        GameObject butn = Instantiate(_prefabOption2, _parentoption2, false);
        _toggleoption1.ToggleList.Add(butn.GetComponent<Interactable>());
        butn.GetComponent<OnClickOption2>()._uiManager = GetComponent<UIManager>();
        var textmesh = butn.GetComponentInChildren<TextMesh>();
        textmesh.text = data.Title;
        textmesh.color = data.Colour;
        _gridOption2.UpdateCollection();
    }
}


