using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Rendering;

public class MaterialManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _audiParts;
    [SerializeField]
    private List<Material> _audiMaterials;
    [SerializeField]
    private Material _transparentMaterial;
    // Start is called before the first frame update
    void Start()
    {
        TransparentEffect();
        //_audiParts[0].GetComponent<Renderer>().sharedMaterial = _transparentMaterial;
        //for (int i = 0; i < _audiParts.Count; i++)
        //{
        //    _audiMaterials[i] = _transparentMaterial;
        //    Debug.Log("asa");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TransparentEffect( /*List<GameObject> skiplist*/)
    {
        for(int i=0;i<_audiParts.Count;i++)
        {
            //if(!skiplist.Contains(_audiParts[i]))
            {
                _audiParts[i].GetComponent<Renderer>().sharedMaterial = _transparentMaterial;
            }
        }
    }
    public void ResetMaterial()
    {
        for (int i = 0; i < _audiParts.Count; i++)
        {
            _audiParts[0].GetComponent<Renderer>().sharedMaterial = _audiMaterials[i];
        }
    }
}
