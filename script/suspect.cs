using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class suspect : MonoBehaviour
{

    public GameObject GetGameObject;

    void OnMouseUp()
    {
        SceneManager.LoadScene("happyEnd");
        GetGameObject.SetActive(false);
        Debug.Log("난 범인이다!!!! ");
        Debug.Log("씬 전환!!!!");
        
    }

}
