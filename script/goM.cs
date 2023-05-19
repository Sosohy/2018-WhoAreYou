using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goM : MonoBehaviour {

    public void goMain()
    {
        Debug.Log("씬 전환!!!!");
        SceneManager.LoadScene("who_opening");
    }
}
