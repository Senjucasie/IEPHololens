﻿
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
        public GameObject showComment, commentPrefab;
        
        public void showKeyboard()
        {
            keyboard.PresentKeyboard();

            keyboard.OnClosed += DisableKeyboard;
            keyboard.OnTextSubmitted += DisableKeyboard;
            keyboard.OnTextUpdated += UpdateText;
        }

        private void UpdateText(string text)
        {
            showComment.GetComponent<TextMeshPro>().text = text;
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
            showComment.GetComponent<TextMeshPro>().text = "Leave a comment...";
            keyboard.OnTextUpdated -= UpdateText;
            keyboard.OnClosed -= DisableKeyboard;
            keyboard.OnTextSubmitted -= DisableKeyboard;

            keyboard.Close();
        } */

        public void createComment()
        {
            var offset = new Vector3(UnityEngine.Random.Range(-0.0f, 0.0f), UnityEngine.Random.Range(-0.0f, 0.0f), 0.5f);
            var spawnPos = CoreServices.InputSystem.GazeProvider.GazeOrigin + Vector3.ClampMagnitude(CoreServices.InputSystem.GazeProvider.GazeDirection, 0.1f) + offset;
            commentPrefab.GetComponentInChildren<TextMeshPro>().text = showComment.GetComponent<TextMeshPro>().text;
            //Instantiate(commentPrefab, spawnPos, Quaternion.identity);
            showComment.GetComponent<TextMeshPro>().text = "Leave a comment...";

            GameObject clone = Instantiate(commentPrefab.gameObject, spawnPos, Quaternion.identity) as GameObject;
            clone.transform.parent = GameObject.Find("Menu").transform;
        }
    }
}