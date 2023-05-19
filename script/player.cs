using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public static int HP;

    public player(int hP)
    {
        HP = hP;
    }

    // Use this for initialization
    void Start()
    {
        HP = 90;
        Debug.Log(" 처음 플레이어의 체력은" + HP + "입니다 ");
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)

        {

            Debug.Log("죽음!!!ㅜㅠㅜ");

            Destroy(gameObject);

        }

    }
}