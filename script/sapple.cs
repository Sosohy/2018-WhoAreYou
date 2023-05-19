using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sapple : MonoBehaviour
{
    public Material skyOne;

    public static int SHP;
    // Use this for initialization
    void Start()
    {
        SHP = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (SHP <= 0)

        {
            RenderSettings.skybox = skyOne;
            Debug.Log("작은사과죽음!!!ㅜㅠㅜ");

            Destroy(gameObject);



        }
    }
}
