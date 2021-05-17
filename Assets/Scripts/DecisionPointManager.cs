using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Utilities;
using TMPro;

public class DecisionPointManager : MonoBehaviour
{
    public List<DecisionDataHolder> Dataholder;
    [SerializeField]
    private GameObject _prefabButn;
    [SerializeField]
    private Transform _parent;
    [SerializeField]
    private GridObjectCollection _grid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddNewComment(Color color,string title,string content)
    {
      DecisionDataHolder  data = new DecisionDataHolder(title,content,color);
      Dataholder.Add(data);
        UpdateGrid(data);
    }
    public void UpdateGrid(DecisionDataHolder data)
    {
        GameObject butn = Instantiate(_prefabButn, _parent, false);
        var textmesh = butn.GetComponentInChildren<TextMesh>();
        textmesh.text = data.Title;
        textmesh.color = data.Colour;
        _grid.UpdateCollection();

    }
}


