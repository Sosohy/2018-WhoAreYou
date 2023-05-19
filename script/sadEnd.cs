using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sadEnd : MonoBehaviour {

    public GameObject end2;

    public void Start()
    {
        StartCoroutine(endS());
    }

    IEnumerator endS()
    {
        yield return new WaitForSeconds(5.0f);
        end2.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
