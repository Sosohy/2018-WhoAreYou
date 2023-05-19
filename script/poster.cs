using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poster : MonoBehaviour {

    public GameObject post;

    void OnMouseUp()
    {
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("OnMouseEnter"); // 쪽지 클릭하면
        post.SetActive(true);
    }

    public void onClick()
    {
        post.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
    }
}
