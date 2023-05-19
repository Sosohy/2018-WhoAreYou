using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class happyEnd : MonoBehaviour {

    public GameObject end1;

    public void Start()
    {
        StartCoroutine(endH());
    }

    IEnumerator endH()
    {
        yield return new WaitForSeconds(5.0f);
        end1.SetActive(true);
    }
}
