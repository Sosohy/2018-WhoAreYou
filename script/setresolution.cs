using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setresolution : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        //화면크기 고정
        Screen.SetResolution( Screen.width , Screen.width / 2 , false);
    }
}
