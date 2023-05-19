using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esc : MonoBehaviour {

    public GameObject exit;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exit.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }

    }

    public void yes()
    {
        if (true)
            Application.Quit();
    }

    public void cancel()
    {
        if (true)
        {
            exit.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;
        }
    }
}
