using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour {

    public void loadLv1()
    {
        Debug.Log("씬 전환!!!!");
        SceneManager.LoadScene("who_level1");
    }

    public void loadLv2()
    {
        Debug.Log("씬 전환!!!!");
        SceneManager.LoadScene("who_level2");
    }

    public void loadLv3()
    {
        Debug.Log("씬 전환!!!!");
        SceneManager.LoadScene("who_level3");
    }

  }
