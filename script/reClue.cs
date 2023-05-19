using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class reClue : MonoBehaviour
{

    public GameObject[] clueIcon;
    public GameObject[] clue;
    public AudioClip soundEffect;

    // Update is called once per frame
    void Update()
    {

        for (int i = 1; i < clueIcon.Length; i++)
        {
            if (clueIcon[i].active == true)
            {
                if (Input.inputString == i.ToString())
                { 
                    Debug.Log(i + " pressed");
                    AudioSource.PlayClipAtPoint(soundEffect, transform.position);
                    clue[i].SetActive(true);
                    Cursor.lockState = CursorLockMode.None;           
                }         
                   }
        }

       
    }



}