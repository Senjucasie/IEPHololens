using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Microsoft.MixedReality.Toolkit.Experimental.UI;
public class UIManager : MonoBehaviour
{

    [SerializeField]
    private GameObject Option1UI, Option2UI;
    [SerializeField]
    private Color _color;
    [SerializeField]
    private DecisionPointManager _decisionPointManager;
    [SerializeField]
    private TMP_Text _content,_title,_decisionContent;
    [SerializeField]
    private NonNativeKeyboard _keyboard;
    private int _index;
    public bool title,Option1;
    public GameObject CommentPrefab,Slate,Commentdiaplay;
    public Transform spawnpos;
    void Start()
    {
        title = false;
        Option1 = false;
    }

   public void ShowAddDP()
    {
        Option1UI.SetActive(true);
        Option1 = true;
    }
    public void ShowAddCommand()
    {
        Option2UI.SetActive(true);
        Option1 = false;
    }

    public void OnclickTitle()
    {
        title = true;
        
    }
    public void OnclickDescription()
    {
        title = false;
    }
   //public void SubmitQuestion(int option)
   // {
       
   //     QuestionUI.SetActive(false);
   //     title = true;
   //     if (option==1)
   //     {
   //         Option1UI.SetActive(true);
   //     }
   //     else if(option==2)
   //     {
   //         Option2UI.SetActive(true);
   //     }
   //     else
   //     {
   //         Debug.LogError("invalid option");
   //     }
   // }

    public void SubmitOption1()
    {
        _keyboard.Close();
        string txt = "\u2022<indent=.5em>" + _content.text+ "</indent>";
        _decisionPointManager.AddNewComment(_color, _title.text, txt);
        Option1UI.SetActive(false);
       // Debug.Log("coming");
        title = false;
    }
    public void SubmitOption2()
    {
        _decisionPointManager.Dataholder[_index].Content = _decisionPointManager.Dataholder[_index].Content+ "\n" + "\u2022<indent=.5em>"  + _content.text+"</indent >";
        title = false;
        _keyboard.Close();
        Option2UI.SetActive(false);
        CreateComment();
    }
    public void Canceloption1()
    {
        Option1UI.SetActive(false);
        _keyboard.Close();
    }
    public void Canceloption2()
    {
        Option2UI.SetActive(false);
        _keyboard.Close();
    }
    public void Oncolorclicked(Image _image)
    {
         _color = _image.color;
    }

    public void OnclickDecisionPoint(int index)
    {
        if(index==0)
        {
            Commentdiaplay.SetActive(false);
            Slate.SetActive(true);
        }
        else
        {
            
            Slate.SetActive(false);
            Commentdiaplay.SetActive(true);
            _decisionContent.text = _decisionPointManager.Dataholder[index].Content;
        }
        
    }
    public void OnclickOption2(int index)
    {
        Debug.Log(index);
        _index = index;
    }
    public void CreateComment()
    {
        GameObject comment=Instantiate(CommentPrefab, spawnpos.position,Quaternion.identity);
        comment.transform.GetChild(0).GetComponent<TextMeshPro>().text = _decisionPointManager.Dataholder[_index].Title;
        comment.transform.GetChild(1).GetComponent<TextMeshPro>().text = _decisionPointManager.Dataholder[_index].Content;
    }
}
