using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lapple : MonoBehaviour
{

    public static int lHP;

    void Start()
    {
        lHP = 3;
    }


    void Update()
    {
        Debug.Log(message: "큰사과체력은" + lHP);
        NewMethod();
    }

    private void NewMethod()
    {
        if (lHP <= 0)

        {

            Debug.Log("큰사과죽음!!!ㅜㅠㅜ");
            SceneManager.LoadScene("sadEnd");

        }
    }
}
