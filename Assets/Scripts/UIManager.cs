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
    private TMP_Text _content,_title;
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
        _decisionPointManager.AddNewComment(_color, _title.text, _content.text);
        ui.SetActive(false);
        title = false;
    }
    public void SubmitOption2()
    {

    }
    public void Oncolorclicked(Image _image)
    {
         _color = _image.color;
    }
}
