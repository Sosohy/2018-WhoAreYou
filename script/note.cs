using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class note : MonoBehaviour
{

    public GameObject noteObj; // 쪽지
    public GameObject clue;
    public GameObject clueIcon;
    public AudioClip soundEffect;


    void OnMouseUp()
    {
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("OnMouseEnter"); // 쪽지 클릭하면
        noteObj.SetActive(false); //  쪽지 없애기
        AudioSource.PlayClipAtPoint(soundEffect, transform.position);
        clue.SetActive(true);

    }

   public void onClick()
    {
        clue.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
        clueIcon.SetActive(true);
    }
}
