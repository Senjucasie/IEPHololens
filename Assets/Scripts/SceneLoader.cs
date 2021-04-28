using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
   //public GameObject tools;

   public void LoadSceneHandCoach(int level)
    {
        Application.LoadLevel("HandCoach");
    }

    public void LoadSceneEnvironment(int level)
    {
        Application.LoadLevel("Environment");
    }

    public void LoadSceneBasic(int level)
    {
        Application.LoadLevel("Basic");
    }

    void Awake()
    {
        //tools.SetActive(false);
    }
}
