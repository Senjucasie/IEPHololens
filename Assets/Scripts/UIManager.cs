using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Microsoft.MixedReality.Toolkit.Experimental.UI;
public class UIManager : MonoBehaviour
{
    
    [SerializeField]
    private GameObject Option1UI, Option2UI, QuestionUI;
    [SerializeField]
    private Color _color;
    [SerializeField]
    private DecisionPointManager _decisionPointManager;
    [SerializeField]
    private TMP_Text _content,_title,_decisionContent;
    [SerializeField]
    private NonNativeKeyboard _keyboard;

    public bool title;
    void Start()
    {
        title = false;
        
    }

    public void DisplayQuestion()
    {
        if(!title)
        QuestionUI.SetActive(true);
    }

   public void SubmitQuestion(int option)
    {
       
        QuestionUI.SetActive(false);
        title = true;
        if (option==1)
        {
            Option1UI.SetActive(true);
        }
        else if(option==2)
        {
            Option2UI.SetActive(true);
        }
        else
        {
            Debug.LogError("invalid option");
        }
    }

    public void SubmitOption1(GameObject ui)
    {
        _keyboard.Close();
        string txt = "\u2022<indent=.5em>" + _content.text;
        _decisionPointManager.AddNewComment(_color, _title.text, txt);
        ui.SetActive(false);
        Debug.Log("coming");
        title = false;
    }
    public void SubmitOption2()
    {

    }
    public void Oncolorclicked(Image _image)
    {
         _color = _image.color;
    }

    public void OnclickDecisionPoint(int index)
    {
        _decisionContent.text = _decisionPointManager.Dataholder[index].Content;
    }
    public void OnclickOption2(int index)
    {
        
        _decisionPointManager.Dataholder[index].Content = _decisionPointManager.Dataholder[index].Content + "\n"+ "\u2022<indent=.5em>" + _content.text;
        Option2UI.SetActive(false);
        
    }
}
