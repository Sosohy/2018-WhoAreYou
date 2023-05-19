using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActive : MonoBehaviour {

    public GameObject mgame;
    public GameObject key;

    public void OnClick()
    {
        key.gameObject.SetActive(false);
        mgame.gameObject.SetActive(true);
    }


}
