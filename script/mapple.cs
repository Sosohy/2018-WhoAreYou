using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapple : MonoBehaviour
{

    public static int MHP;
    public Material skyTwo;


    void Start()
    {
        MHP = 2;
    }


    void Update()
    {
        Debug.Log(message: "중간사과체력은" + MHP);
        if (MHP <= 0)

        {

            Debug.Log("중간사과죽음!!!ㅜㅠㅜ");
            RenderSettings.skybox = skyTwo;
            Destroy(gameObject);



        }
    }
}
