using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using Microsoft.MixedReality.Toolkit.UI;
public class MaterialManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _audiParts;
    [SerializeField]
    private List<Material> _audiMaterials;
    [SerializeField]
    private Material _transparentMaterial;
    [SerializeField]
    private BoxCollider _audiCollider;
    [SerializeField]
    private BoundsControl _audiBounds;
    [SerializeField]
    private bool _firstPass;
    [SerializeField]
    private GameObject _decisionPoints;
    [SerializeField]
    private ObjectManipulator _object;
    public BoxCollider[] tyre;
    // Start is called before the first frame update
    void Start()
    {
        _firstPass = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    for (int i = 0; i < _audiParts.Count; i++)
        //    {
        //        _audiParts[i].GetComponent<Renderer>().sharedMaterial = _transparentMaterial;
        //    }
        //}
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    for (int i = 0; i < _audiParts.Count; i++)
        //    {
        //        _audiParts[i].GetComponent<Renderer>().sharedMaterial = _audiMaterials[i];
        //        Debug.Log("going");
        //    }
        //}
    }
    public void TransparentEffect( List<GameObject> skiplist)
    {
        if(!_firstPass)
        {
        _firstPass = true;
        }
        for(int i=0;i<_audiParts.Count;i++)
        {
            if(!skiplist.Contains(_audiParts[i]))
            {
                _audiParts[i].GetComponent<Renderer>().sharedMaterial = _transparentMaterial;
            }
        }
        _decisionPoints.SetActive(true);
    }
    public void ResetMaterial(BoxCollider[] coll)
    {
        _decisionPoints.SetActive(false);
       for (int i=0;i<coll.Length;i++)
        {
            coll[i].enabled = false;
        }
        if(_firstPass)
        {
            for (int i = 0; i < _audiParts.Count; i++)
            {
                _audiParts[i].GetComponent<Renderer>().sharedMaterial = _audiMaterials[i];
                Debug.Log("going");
            }
        }
        _object.enabled = true;
        _audiCollider.enabled = true;
        _audiBounds.enabled = true;
    }
    public void Showtyres()
    {
        _object.enabled = false;
        _audiCollider.enabled = false;
        _audiBounds.enabled = false;
        for (int i = 0; i < tyre.Length; i++)
        {
            tyre[i].enabled = true;
        }
    }
}
