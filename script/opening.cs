using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class opening : MonoBehaviour {

    public GameObject openingO;
    public GameObject levelC;
    public GameObject Gname;

    // Use this for initialization
    void Start () {
		
	}

    public void OnClick()
    {
        Gname.gameObject.SetActive(false);
        openingO.gameObject.SetActive(false);
        levelC.gameObject.SetActive(true);
    }
}
