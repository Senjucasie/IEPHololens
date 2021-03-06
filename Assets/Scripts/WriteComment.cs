
using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;


namespace Microsoft.MixedReality.Toolkit.Experimental.UI
{
    /// <summary>
    /// This component links the NonNativeKeyboard to a TMP_InputField
    /// Put it on the TMP_InputField and assign the NonNativeKeyboard.prefab
    /// </summary>
    public class WriteComment : MonoBehaviour
    {
        [Experimental]
        [SerializeField] private NonNativeKeyboard keyboard = null;
       // public GameObject content, commentPrefab,title;
        public TMP_InputField DescrptionOption1,TitleOption1,DescriptionOption2;
        //public TextMeshProUGUI DescrptionOption1, TitleOption1, DescriptionOption2;
        public UIManager uimanager;
        [SerializeField]
        private Transform defaultpos, movepos;
        
        public void showKeyboard()
        {
#if UNITY_EDITOR
            keyboard.Close();
            //if(uimanager.title)
            //{
            //    keyboard.transform.position = movepos.position;
            //}
            //else
            //{
            //    keyboard.transform.position = defaultpos.position;
            //}
            keyboard.PresentKeyboard();

            keyboard.OnClosed += DisableKeyboard;
            keyboard.OnTextSubmitted += DisableKeyboard;
            keyboard.OnTextUpdated += UpdateText;
#endif
        }

        private void UpdateText(string text)
        {
            if(uimanager.Option1)
            {
                if (uimanager.title)
                {
                    //title.GetComponent<TextMeshPro>().text = text;
                 #if UNITY_EDITOR
                    TitleOption1.text = text;
                 #endif
                }
                else
                {
                #if UNITY_EDITOR
                    DescrptionOption1.text = text;
                #endif
                }
            }
            else
            {
            #if UNITY_EDITOR
                DescriptionOption2.text = text;
            #endif
            }


        }

        private void DisableKeyboard(object sender, EventArgs e)
        {
            keyboard.OnTextUpdated -= UpdateText;
            keyboard.OnClosed -= DisableKeyboard;
            keyboard.OnTextSubmitted -= DisableKeyboard;

            keyboard.Close();
        }

/*         public void cancelCom()
        {
            content.GetComponent<TextMeshPro>().text = "Leave a comment...";
            keyboard.OnTextUpdated -= UpdateText;
            keyboard.OnClosed -= DisableKeyboard;
            keyboard.OnTextSubmitted -= DisableKeyboard;

            keyboard.Close();
        } */

        //public void createComment()
        //{
        //    var offset = new Vector3(UnityEngine.Random.Range(-0.0f, 0.0f), UnityEngine.Random.Range(-0.0f, 0.0f), 0.5f);
        //    var spawnPos = CoreServices.InputSystem.GazeProvider.GazeOrigin + Vector3.ClampMagnitude(CoreServices.InputSystem.GazeProvider.GazeDirection, 0.1f) + offset;
        //    commentPrefab.GetComponentInChildren<TextMeshPro>().text = content.GetComponent<TextMeshPro>().text;
        //    //Instantiate(commentPrefab, spawnPos, Quaternion.identity);
        //    content.GetComponent<TextMeshPro>().text = "Leave a comment...";

        //    GameObject clone = Instantiate(commentPrefab.gameObject, spawnPos, Quaternion.identity) as GameObject;
        //    clone.transform.parent = GameObject.Find("Menu").transform;
        //}
    }
}